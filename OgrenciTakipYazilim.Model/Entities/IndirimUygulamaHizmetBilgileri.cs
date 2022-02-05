using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class IndirimUygulamaHizmetBilgileri : BaseHaraketEntity
    {
        public long IndirimId { get; set; }
        public long HizmetId { get; set; }
        [Column(TypeName = "money")]
        public decimal IndirimTutar { get; set; }
        public byte IndirimOran { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        public Indirim Indirim { get; set; }
        public Hizmet Hizmet { get; set; }
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }
    }
}