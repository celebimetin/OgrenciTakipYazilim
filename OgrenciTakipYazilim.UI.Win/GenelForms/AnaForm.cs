using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.AileBilgiForms;
using OgrenciTakipYazilim.UI.Win.Forms.AvukatForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaHesapForms;
using OgrenciTakipYazilim.UI.Win.Forms.CariForms;
using OgrenciTakipYazilim.UI.Win.Forms.EvrakForms;
using OgrenciTakipYazilim.UI.Win.Forms.GorevForms;
using OgrenciTakipYazilim.UI.Win.Forms.HizmetForms;
using OgrenciTakipYazilim.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.IletisimForms;
using OgrenciTakipYazilim.UI.Win.Forms.IlForms;
using OgrenciTakipYazilim.UI.Win.Forms.IndirimForms;
using OgrenciTakipYazilim.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakipYazilim.UI.Win.Forms.IsyeriForms;
using OgrenciTakipYazilim.UI.Win.Forms.KasaForms;
using OgrenciTakipYazilim.UI.Win.Forms.KontenjanForms;
using OgrenciTakipYazilim.UI.Win.Forms.MeslekForms;
using OgrenciTakipYazilim.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.OgrenciForms;
using OgrenciTakipYazilim.UI.Win.Forms.OkulForms;
using OgrenciTakipYazilim.UI.Win.Forms.PromosyonForms;
using OgrenciTakipYazilim.UI.Win.Forms.RehberForms;
using OgrenciTakipYazilim.UI.Win.Forms.ServisForms;
using OgrenciTakipYazilim.UI.Win.Forms.SinifForms;
using OgrenciTakipYazilim.UI.Win.Forms.SinifGrupForms;
using OgrenciTakipYazilim.UI.Win.Forms.TahakkukForms;
using OgrenciTakipYazilim.UI.Win.Forms.TesvikForms;
using OgrenciTakipYazilim.UI.Win.Forms.YabanciDilForms;
using OgrenciTakipYazilim.UI.Win.Forms.YakinlikForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.GenelForms
{
    public partial class AnaForm : RibbonForm
    {
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
        public static string SubeAdi = "Şube Bilgisi Bekleniyor...";
        public static long SubeId = 1;
        public static long DonemId = 1;

        public static DateTime EgitimBaslamaTarihi = new DateTime(2020,09,15);
        public static DateTime DonemBaslamaTarihi = new DateTime(2020, 07, 15);
        public static DateTime DonemBitisTarihi = new DateTime(2021, 06, 15);

        public static bool GununTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GununTarihininSonrasınaHizmetBaslamaTarihiGirilebilir = true;

        public static bool GununTarihininOncesineIptalTarihiGirilebilir = true;
        public static bool GununTarihininSonrasınaIptalTarihiGirilebilir = true;

        public static bool HizmetTahakkukKurusKullan;
        public static bool IndirimTahakkukKurusKullan;
        public static bool OdemePlaniKurusKullan;

        public static bool GittigiOkulZorunlu = true;

        public static DateTime MaksimumTaksitTarihi = new DateTime(2021, 06, 15);
        public static byte MaksimumTaksitSayisi = 12;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (object item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
            {
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            }
            else if (e.Item == btnIlKartlari)
            {
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            }
            else if (e.Item == btnAileBilgiKartlari)
            {
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            }
            else if (e.Item == btnIptalNedenKartlari)
            {
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            }
            else if (e.Item == btnYabanciDilKartlari)
            {
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            }
            else if (e.Item == btnTesvikKartlari)
            {
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            }
            else if (e.Item == btnKontenjanKartlari)
            {
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            }
            else if (e.Item == btnRehberKartlari)
            {
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            }
            else if (e.Item == btnSinifGrupKartları)
            {
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            }
            else if (e.Item == btnMeslekKartlari)
            {
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            }
            else if (e.Item == btnYakinlikKartlari)
            {
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            }
            else if (e.Item == btnIsyeriKartlari)
            {
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            }
            else if (e.Item == btnGorevKartlari)
            {
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            }
            else if (e.Item == btnIndirimTuruKartlari)
            {
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            }
            else if (e.Item == btnEvrakKartlari)
            {
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            }
            else if (e.Item == btnPromosyonKartlari)
            {
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            }
            else if (e.Item == btnServisKartlari)
            {
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            }
            else if (e.Item == btnSinifKartlari)
            {
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            }
            else if (e.Item == btnHizmetTuruKartlari)
            {
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            }
            else if (e.Item == btnHizmetKartlari)
            {
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            }
            else if (e.Item == btnKasaKartlari)
            {
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            }
            else if (e.Item == btnBankaKartlari)
            {
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            }
            else if (e.Item == btnAvukatKartlari)
            {
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            }
            else if (e.Item == btnCariKartlari)
            {
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            }
            else if (e.Item == btnOdemeTuruKartlari)
            {
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            }
            else if (e.Item == btnBankaHesapKartlari)
            {
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            }
            else if (e.Item == btnIletisimKartlari)
            {
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            }
            else if (e.Item == btnOgrenciKartları)
            {
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            }
            else if (e.Item == btnIndirimKartları)
            {
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            }
            else if (e.Item == btnTahakkukKartlari)
            {
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            }
        }
    }
}