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
    public class KardesBilgileriBll : BaseHareketBll<KardesBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<KardesBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<KardesBilgileri, bool>> filter)
        {
            return List(filter, x => new KardesBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                KardesTahakkukId = x.KardesTahakkukId,
                Adi = x.KardesTahakkuk.Ogrenci.Adi,
                Soyadi = x.KardesTahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.KardesTahakkuk.Sinif.SinifAdi,
                KayitSekli = x.KardesTahakkuk.KayitSekli,
                KayitDurumu = x.KardesTahakkuk.KayitDurumu,
                IptalDurumu = x.KardesTahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SubeId = x.KardesTahakkuk.SubeId,
                SubeAdi = x.KardesTahakkuk.Sube.SubeAdi
            }).ToList();
        }
    }
}