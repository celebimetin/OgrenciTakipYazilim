using System;
using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class BilgiNotlari : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public DateTime Tarih { get; set; }
        [Required, StringLength(1000)]
        public string BilgiNotu { get; set; }
    }
}