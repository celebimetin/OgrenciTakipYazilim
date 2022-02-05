using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Data.Contexts;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class EposBilgileriBll : BaseHareketBll<EposBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EposBilgileri>
    {
        public IEnumerable<BaseHaraketEntity> List(Expression<Func<EposBilgileri, bool>> filter)
        {
            var entities =  List(filter, x => new EposBilgileriL()
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                BankaId = x.BankaId,
                BankaAdi = x.Banka.BankaAdi,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                EposKartTuru = x.EposKartTuru,
                KartNo = x.KartNo,
                SonkullanmaTarihi = x.SonkullanmaTarihi,
                GuvenlikKod = x.GuvenlikKod
            }).ToList();

            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;

                entity.KartNo = entity.KartNo.Decrypt(anahtar);
                entity.SonkullanmaTarihi = entity.SonkullanmaTarihi.Decrypt(anahtar);
                entity.GuvenlikKod = entity.GuvenlikKod.Decrypt(anahtar);
            }

            return entities;
        }

        public override bool Insert(IList<BaseHaraketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;

                entity.KartNo = entity.KartNo.Emcrypt(anahtar);
                entity.SonkullanmaTarihi = entity.SonkullanmaTarihi.Emcrypt(anahtar);
                entity.GuvenlikKod = entity.GuvenlikKod.Emcrypt(anahtar);
            }

            return base.Insert(entities);
        }

        public override bool Update(IList<BaseHaraketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;

                entity.KartNo = entity.KartNo.Emcrypt(anahtar);
                entity.SonkullanmaTarihi = entity.SonkullanmaTarihi.Emcrypt(anahtar);
                entity.GuvenlikKod = entity.GuvenlikKod.Emcrypt(anahtar);
            }

            return base.Update(entities);
        }
    }
}