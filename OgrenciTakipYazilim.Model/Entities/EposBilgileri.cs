using System.ComponentModel.DataAnnotations;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class EposBilgileri : BaseHaraketEntity
    {
        public long TahakkukId { get; set; }
        public long BankaId { get; set; }
        [Required, StringLength(20)]
        public string Adi { get; set; }
        [Required, StringLength(20)]
        public string Soyadi { get; set; }
        public EposKartTuru EposKartTuru { get; set; } = EposKartTuru.Visa;
        [Required, StringLength(55)]
        public string KartNo { get; set; }
        [Required, StringLength(55)]
        public string SonkullanmaTarihi { get; set; }
        [Required, StringLength(55)]
        public string GuvenlikKod { get; set; }

        public Banka Banka { get; set; }
    }
}