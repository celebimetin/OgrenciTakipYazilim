using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AbcYazilim.Dal.Interfaces;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBaseHareketGenelBll
        where T : BaseHaraketEntity
        where TContext : DbContext
    {
        private IUnitOfWork<T> _unitOfWork;

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.GetRepository.Select(filter, selector);
        }

        public virtual bool Insert(IList<BaseHaraketEntity> entities)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
           
            _unitOfWork.GetRepository.Insert(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public virtual bool Update(IList<BaseHaraketEntity> entities)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
         
            _unitOfWork.GetRepository.Update(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public bool Delete(IList<BaseHaraketEntity> entities)
        {
            GeneralFunctionsBll.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
          
            _unitOfWork.GetRepository.Delete(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        #region Disposable

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }
        #endregion
    }
}