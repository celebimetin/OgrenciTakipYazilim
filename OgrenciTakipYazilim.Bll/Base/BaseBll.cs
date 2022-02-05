using AbcYazilim.Dal.Interfaces;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Attributes;
using OgrenciTakipYazilim.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;


namespace OgrenciTakipYazilim.Bll.Base
{
    public class BaseBll<T, TContext> : IBaseBll
        where T : BaseEntity
        where TContext : DbContext
    {
        private readonly Control _control;
        private IUnitOfWork<T> _unitOfWork;

        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();
            if (errorControl == null)
            {
                return true;
            }
            _control.Controls[errorControl].Focus();
            return false;

            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null)
                        {
                            continue;
                        }
                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == currentEntity.Kod) && islemTuru == IslemTuru.EntityUpdate)
                        {
                            continue;
                        }
                        if (_unitOfWork.GetRepository.Count(filter) < 1)
                        {
                            continue;
                        }
                        Messages.MukerrerKayitHataMesaj(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null)
                        {
                            continue;
                        }
                        var value = property.Property.GetValue(currentEntity);

                        if (property.Property.PropertyType == typeof(long))
                            if((long)value == 0)
                            {
                                value = null;
                            }
                        if (!string.IsNullOrEmpty(value?.ToString()))
                        {
                            continue;
                        }

                        Messages.HataliGirisMesaj(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                return HataliGiris() ?? MukerrerKod();
            }
        }

        protected BaseBll() { }

        protected BaseBll(Control control)
        {
            _control = control;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.GetRepository.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.GetRepository.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity baseEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.EntityInsert, null, baseEntity, filter))
            {
                return false;
            }
            _unitOfWork.GetRepository.Insert(baseEntity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldBaseEntity, BaseEntity currentBaseEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.EntityUpdate, oldBaseEntity, currentBaseEntity, filter))
            {
                return false;
            }
            var degisenAlanlar = oldBaseEntity.DegisenAlanlarıGetir(currentBaseEntity);
            if (degisenAlanlar.Count == 0)
            {
                return true;
            }
            _unitOfWork.GetRepository.Update(currentBaseEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity baseEntity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (mesajVer)
            {
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes)
                {
                    return false;
                }
            }
            _unitOfWork.GetRepository.Delete(baseEntity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.GetRepository.YeniKodVer(kartTuru, filter, where);
        }

        #region Disposable

        public void Dispose()
        {
            _control?.Dispose();
            _unitOfWork?.Dispose();
        }
        #endregion
    }
}
