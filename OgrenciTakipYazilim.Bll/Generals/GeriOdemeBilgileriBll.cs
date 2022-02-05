using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Data.Contexts;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class GeriOdemeBilgileriBll : BaseHareketBll<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                HesapTuru = x.HesapTuru,
                HesapId = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.KasaId : x.BankaHesapId,
                HesapAdi = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.Kasa.KasaAdi : x.BankaHesap.HesapAdi,
                BankaHesapId = x.BankaHesapId,
                KasaId = x.KasaId,
                Tutar = x.Tutar,
                Aciklama = x.Aciklama
            }).ToList();
        }
    }
}