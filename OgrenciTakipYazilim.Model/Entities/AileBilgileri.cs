using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class AileBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public long AileBilgiId { get; set; }
        [StringLength(250)]
        public string Aciklama { get; set; }

        public AileBilgi AileBilgi { get; set; }
    }
}