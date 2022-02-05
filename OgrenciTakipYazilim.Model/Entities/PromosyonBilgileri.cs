using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class PromosyonBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public long PromosyonId { get; set; }

        public Promosyon Promosyon { get; set; }
    }
}