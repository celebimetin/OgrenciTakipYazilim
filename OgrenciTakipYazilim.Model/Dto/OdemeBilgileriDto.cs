﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;

namespace OgrenciTakipYazilim.Model.Dto
{
    [NotMapped]
    public class OdemeBilgileriL : OdemeBilgileri, IBaseHareketEntity
    {
        public string OdemeTuruAdi { get; set; }
        public string BankaHesapAdi { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string SubeAdi { get; set; }
        public string SubeIlAdi { get; set; }
        public decimal Tahsil { get; set; }
        public decimal Tahsilde { get; set; }
        public decimal Iade { get; set; }
        public decimal Kalan { get; set; }
        public long? SonHareketId { get; set; }
        public DateTime? SonHareketTarih { get; set; }
        public string SonIslemYeri { get; set; }
        public BelgeDurumu BelgeDurumu { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}