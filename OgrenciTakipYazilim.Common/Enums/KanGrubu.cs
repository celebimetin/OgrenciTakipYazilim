using System.ComponentModel;

namespace OgrenciTakipYazilim.Common.Enums
{
    public enum KanGrubu : byte
    {
        [Description("...")]
        Bos = 0,
        [Description("(0)Negatif")]
        SifirNegatif = 1,
        [Description("(0)Pozitif")]
        SifirPozitif = 2,
        [Description("(A)Negatif")]
        ANegatif = 3,
        [Description("(A)Pozitif")]
        APozitif = 4,
        [Description("(B)Negatif")]
        BNegatif = 5,
        [Description("(B)Pozitif")]
        BPozitif = 6,
        [Description("(AB)Negatif")]
        ABNegatif = 7,
        [Description("(AB)Pozitif")]
        ABPozitif = 8
    }
}