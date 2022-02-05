using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Model.Attributes;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class Sube : BaseEntityDurum
    {
        [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
        public string SubeAdi { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }
        [ZorunluAlan("İl Adı", "txtAdresIl")]
        public long AdresIlId { get; set; }
        [ZorunluAlan("İlçe Adı", "txtAdresIlce")]
        public long AdresIlceId { get; set; }

        public Il AdresIl { get; set; }
        public Ilce AdresIlce { get; set; }
    }
}