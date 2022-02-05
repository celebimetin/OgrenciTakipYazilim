using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Data.Contexts;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriL()
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Kod = x.Evrak.Kod,
                EvrakId = x.EvrakId,
                EvrakAdi = x.Evrak.EvrakAdi,
            }).ToList();
        }
    }
}