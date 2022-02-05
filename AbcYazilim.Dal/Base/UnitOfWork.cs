using AbcYazilim.Dal.Interfaces;
using OgrenciTakipYazilim.Common.Messages;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace AbcYazilim.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T>
        where T : class
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            if (context == null)
            {
                return;
            }
            _context = context;
        }

        public IRepository<T> GetRepository => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException sqlExp = (SqlException)e.InnerException?.InnerException;
                if (sqlExp == null)
                {
                    Messages.HataMesaji(e.Message);
                    return false;
                }

                switch (sqlExp.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem yapmak istediğiniz tablo veritabanında bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kartın işlem görmüş haraketleri var kart silinemez!");
                        break;
                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş olduğunuz ID daha önce kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem yapmak istedediğiniz veri tabanı sunucuda bulunamadı.");
                        break;
                    case 18456:
                        Messages.HataMesaji("Server'a bağlanılmak istenilen kullanıcı adı şifre hatalıdır.");
                        break;
                    default:
                        Messages.HataMesaji(sqlExp.Message);
                        break;
                }
                return false;
            }
            catch (Exception e)
            {
                Messages.HataMesaji(e.Message);
                return false;
            }

            return true;
        }

        #region Dispose

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
