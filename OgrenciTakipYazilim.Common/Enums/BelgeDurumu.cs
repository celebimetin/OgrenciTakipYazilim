using System.ComponentModel;

namespace OgrenciTakipYazilim.Common.Enums
{
    public enum BelgeDurumu : byte
    {
        [Description("PortFöyde")]
        PortFoyde = 1,
        [Description("Tahsil Etme Kasa")]
        TahsilEtmeKasa = 2,
        [Description("Tahsil Etme Banka")]
        TahsilEtmeBanka = 3,
        [Description("Kısmi Tahsil Edildi")]
        KismiTahsilEdildi = 4,
        [Description("Bankaya Tahsile Gonderme")]
        BankayaTahsileGonderme = 5,
        [Description("Banka Yoluyla Tahsil Etme")]
        BankaYoluylaTahsilEtme = 6,
        [Description("PortFöye Geri İade")]
        PortFoyeGeriIade = 7,
        [Description("PortFöye Karsılıksız İade")]
        PortFoyeKarsiliksizIade = 8,
        [Description("Avukata Gönderme")]
        AvukataGonderme = 9,
        [Description("Avukat Yoluyla Tahsil Etme")]
        AvukatYoluylaTahsilEtme = 10,
        [Description("Kısmi Avukat Yoluyla Tahsil Etme")]
        KismiAvukatYoluylaTahsilEtme = 11,
        [Description("Bloke Alma")]
        BlokeAlma = 12,
        [Description("Bloke Cözümü")]
        BlokeCozumu = 13,
        [Description("Ciro Etme")]
        CiroEtme = 14,
        [Description("Müsteriye Geri İade")]
        MusteriyeGeriIade = 15,
        [Description("Mahsup Etme")]
        MahsupEtme = 16,
        [Description("Onay Bekliyor")]
        OnayBekliyor = 17,
        [Description("Ödenmiş Olarak İşaretleme")]
        OdenmisOlarakIsaretleme = 18,
        [Description("Karşılıksız Olarak İşaretleme")]
        KarsiliksizOlarakIsaretleme = 19,
        [Description("Tahsili İmkansız Hale Gelme")]
        TahsiliImkansızHaleGelme = 20
    }
}