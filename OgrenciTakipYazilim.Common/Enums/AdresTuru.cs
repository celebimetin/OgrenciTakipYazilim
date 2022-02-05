using System.ComponentModel;

namespace OgrenciTakipYazilim.Common.Enums
{
    public enum AdresTuru : byte
    {
        [Description("İş Adresi")]
        IsAdresi = 1,
        [Description("Ev Adresi")]
        EvAdresi = 2
    }
}