using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class GeriOdemeBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
        public GeriOdemeHesapTuru HesapTuru { get; set; }
        public long? BankaHesapId { get; set; }
        public long? KasaId { get; set; }
        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }
        [StringLength(250)]
        public string Aciklama { get; set; }

        public Tahakkuk Tahakkuk { get; set; }
        public BankaHesap BankaHesap { get; set; }
        public Kasa Kasa { get; set; }
    }
}