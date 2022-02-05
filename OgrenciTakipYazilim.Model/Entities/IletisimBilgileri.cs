using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class IletisimBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public long IletisimId { get; set; }
        public long YakinlikId { get; set; }
        public bool Veli { get; set; }
        public AdresTuru? FaturaAdresi { get; set; }

        public Iletisim Iletisim { get; set; }
        public Yakinlik Yakinlik { get; set; }
    }
}