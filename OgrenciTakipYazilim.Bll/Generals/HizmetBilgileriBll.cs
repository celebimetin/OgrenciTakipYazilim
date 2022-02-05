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
    public class HizmetBilgileriBll : BaseHareketBll<HizmetBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<HizmetBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<HizmetBilgileri, bool>> filter)
        {
            return List(filter, x => new HizmetBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                HizmetId = x.HizmetId,
                HizmetAdi = x.IptalEdildi ? x.Hizmet.HizmetAdi + " - ( *** İptal Edildi *** )" : x.Hizmet.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTipi = x.HizmetTuru.HizmetTipi,
                ServisId = x.ServisId,
                ServisYeriAdi = x.Servis.ServisYeriAdi,
                IslemTarihi = x.IslemTarihi,
                BaslamaTarihi = x.BaslamaTarihi,
                BurutUcret = x.BurutUcret,
                KistDonemDusulenUcret = x.KistDonemDusulenUcret,
                NetUcret = x.NetUcret,
                GunlukUcret = x.GunlukUcret,
                EgitimDonemiGunSayisi = x.EgitimDonemiGunSayisi,
                AlinanHizmetGunSayisi = x.AlinanHizmetGunSayisi,
                IptalNedeniId = x.IptalNedeniId,
                IptalNedeniAdi = x.IptalNedeni.IptalNedenAdi,
                IptalTarihi = x.IptalTarihi,
                IptalAciklama = x.IptalAciklama,
                IptalEdildi = x.IptalEdildi,
                GittigiOkulId = x.GittigiOkulId,
                GittigiOkulAdi = x.GittigiOkul.OkulAdi,
            }).OrderByDescending(x => x.IptalEdildi).ThenBy(x => x.IptalTarihi).ThenBy(x => x.Id).ToList();
        }
    }
}