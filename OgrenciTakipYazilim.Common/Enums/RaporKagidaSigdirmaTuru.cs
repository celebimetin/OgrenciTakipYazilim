using System.ComponentModel;

namespace OgrenciTakipYazilim.Common.Enums
{
    public enum RaporKagidaSigdirmaTuru : byte
    {
        [Description("Sutunları Daraltarak Sıgdır")]
        SutunDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sıgdır")]
        YaziBoyutKuculterekSigdir = 2,
        [Description("İşlem Yapma")]
        IslemYapma = 3
    }
}