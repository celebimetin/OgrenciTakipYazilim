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
    public class IndirimUygulamaHizmetBilgileriBll : BaseHareketBll<IndirimUygulamaHizmetBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IndirimUygulamaHizmetBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<IndirimUygulamaHizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new IndirimUygulamaHizmetBilgileriL
            {
                Id = x.Id,
                IndirimId = x.IndirimId,
                HizmetId = x.HizmetId,
                HizmetAdi = x.Hizmet.HizmetAdi,
                IndirimTutar = x.IndirimTutar,
                IndirimOran = x.IndirimOran,
                SubeId = x.SubeId,
                DonemId = x.DonemId
            }).ToList();
        }
    }
}