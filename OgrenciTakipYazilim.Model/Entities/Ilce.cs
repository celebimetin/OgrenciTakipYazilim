﻿using OgrenciTakipYazilim.Model.Attributes;
using OgrenciTakipYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        public long IlId { get; set; }
        [Required, StringLength(50), ZorunluAlan("İlçe Adı", "txtIlceAdi")]
        public string IlceAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public Il Il { get; set; }
    }
}
