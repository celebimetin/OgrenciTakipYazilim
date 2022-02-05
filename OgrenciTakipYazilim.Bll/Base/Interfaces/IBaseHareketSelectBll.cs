using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Base.Interfaces
{
    public interface IBaseHareketSelectBll<T>
    {
        IEnumerable<BaseHaraketEntity> List(Expression<Func<T, bool>> filter);
    }
}