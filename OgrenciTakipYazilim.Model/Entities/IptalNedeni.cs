using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Model.Attributes;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class IptalNedeni : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İptal Nedeni Adı", "txtIptalNedeni")]
        public string IptalNedenAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}