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
    public class OdemeBilgileriBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<OdemeBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<OdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                OdemeBelgesi = x
                //Toplamlar = 

            }).Select(x => new OdemeBilgileriL
            {
                Id = x.OdemeBelgesi.Id,
                TahakkukId = x.OdemeBelgesi.TahakkukId,
                OdemeTuruId = x.OdemeBelgesi.OdemeTuruId,
                OdemeTuruAdi = x.OdemeBelgesi.OdemeTuru.OdemeTuruAdi,
                OdemeTipi = x.OdemeBelgesi.OdemeTipi,
                BankaHesapId = x.OdemeBelgesi.BankaHesapId,
                BankaHesapAdi = x.OdemeBelgesi.BankaHesap.HesapAdi,
                BlokeGunSayisi = x.OdemeBelgesi.BlokeGunSayisi,
                GirisTarihi = x.OdemeBelgesi.GirisTarihi,
                Vade = x.OdemeBelgesi.Vade,
                HesabaGecisTarihi = x.OdemeBelgesi.HesabaGecisTarihi,
                Tutar = x.OdemeBelgesi.Tutar,
                TakipNo = x.OdemeBelgesi.TakipNo,
                BankaId = x.OdemeBelgesi.BankaId,
                BankaAdi = x.OdemeBelgesi.Banka.BankaAdi,
                BankaSubeId = x.OdemeBelgesi.BankaSubeId,
                BankaSubeAdi = x.OdemeBelgesi.BankaSube.SubeAdi,
                BelgeNo = x.OdemeBelgesi.BelgeNo,
                HesapNo = x.OdemeBelgesi.HesapNo,
                AsilBorclu = x.OdemeBelgesi.AsilBorclu,
                Ciranta = x.OdemeBelgesi.Ciranta,
                TutarYazi = x.OdemeBelgesi.TutarYazi,
                VadeYazi = x.OdemeBelgesi.VadeYazi,
                Aciklama = x.OdemeBelgesi.Aciklama,
                SubeAdi = x.OdemeBelgesi.Tahakkuk.Sube.SubeAdi,
                SubeIlAdi = x.OdemeBelgesi.Tahakkuk.Sube.AdresIl.IlAdi,
                Tahsil = 0,
                Tahsilde = 0,
                Iade = 0,
                Kalan = x.OdemeBelgesi.Tutar,
                BelgeDurumu = BelgeDurumu.PortFoyde,
                SonHareketId = null,
                SonHareketTarih = null,
                SonIslemYeri = null
            }).ToList();
        }
    }
}