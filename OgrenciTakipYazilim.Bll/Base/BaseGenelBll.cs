using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Data.Contexts;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Base
{
    public class BaseGenelBll<T> : BaseBll<T, OgrenciTakipContext>
    where T : BaseEntity
    {
        private readonly KartTuru _kartTuru;

        public BaseGenelBll(KartTuru kartTuru)
        {
            _kartTuru = kartTuru;
        }

        public BaseGenelBll(Control control, KartTuru kartTuru) : base(control)
        {
            _kartTuru = kartTuru;
        }

        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity baseEntity)
        {
            return BaseInsert(baseEntity, x => x.Kod == baseEntity.Kod);
        }

        public bool Insert(BaseEntity baseEntity, Expression<Func<T, bool>> filter)
        {
            return BaseInsert(baseEntity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity baseEntity)
        {
            return BaseDelete(baseEntity, _kartTuru);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<T, bool>> filter)
        {
            return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
        }
    }
}