using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class EvrakBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public long EvrakId { get; set; }

        public Evrak Evrak { get; set; }
    }
}