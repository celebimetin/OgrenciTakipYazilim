﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Dto
{
    [NotMapped]
    public class TahakkukS : Tahakkuk
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }

        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }

        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }

    public class TahakkukL : BaseEntity
    {
        public long OgrenciId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string OkulNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public SonrakiDonemKayitDurumu SonrakiDonemKayitDurumu { get; set; }
        public string SonrakiDonemKayitDurumuAciklama { get; set; }

        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string KontenjanAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string RehberAdi { get; set; }
        public string TesvikAdi { get; set; }

        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }

        public string SubeAdi { get; set; }
        public bool Durum { get; set; }
    }
}