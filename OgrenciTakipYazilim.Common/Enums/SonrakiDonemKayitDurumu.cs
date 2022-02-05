using System.ComponentModel;

namespace OgrenciTakipYazilim.Common.Enums
{
    public enum SonrakiDonemKayitDurumu : byte
    {
        [Description("Kayıt Yenile")]
        KayitYenile = 1,
        [Description("Şartlı Kayıt Yenile")]
        SartliKayitYenile = 2,
        [Description("Kayıt Yenilenmeyecek")]
        KayitYenilenmeyecek = 3,
        [Description("Kurum Tarafından Kaydı Yenilenmeyecek")]
        KurumTarafındanKaydiYenilennmeyecek = 4
    }
}