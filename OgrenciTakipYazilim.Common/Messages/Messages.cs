using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciTakipYazilim.Common.Messages
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyarıMesaji(string uyarıMesaji)
        {
            XtraMessageBox.Show(uyarıMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void KartUyarıMesaji()
        {
            UyarıMesaji("Lütfen Bir Kart Seçiniz.!");
        }

        public static void KartBulunamadiMesaj(string kartTuru)
        {
            UyarıMesaji($"İşlem Yapılabilecek {kartTuru} Bulunamadı.!");
        }

        public static void OdemeBelgesiSilinemezMesaj(bool dahaSonra)
        {
            UyarıMesaji(dahaSonra 
                ? "Ödeme Belgesinin daha sonra İşlem Görmüş Hareketleri var. Ödeme Belgesi Silinemez." 
                : "Ödeme Belgesinin İşlem Görmüş Hareketleri var. Ödeme Belgesi Silinemez.");
        }

        public static void TabloEksikBilgiMesaj(string tabloAdi)
        {
            UyarıMesaji($"{tabloAdi} Eksik Bilgi Girişi Var. Lütfen Kontrol Ediniz.!");
        }

        public static void IptalEdilenHareketSilinemezMesaj()
        {
            HataMesaji("İptal Edilen Hareketler Silinemez.!");
        }

        public static void SecimHataMesaj(string alanAdi)
        {
            HataMesaji($"{alanAdi} Seçim Yapmalısınız.");
        }

        public static void MukerrerKayitHataMesaj(string alanAdi)
        {
            HataMesaji($"Girmiş Olduğunuz {alanAdi} Daha Önce Kullanılmıştır.");
        }

        public static void HataliGirisMesaj(string alanAdi)
        {
            HataMesaji($"{alanAdi} Alanına Geçerli Bir Değer Girmelisiniz.");
        }

        public static DialogResult EvetSeciliEvetHayır(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayırSeciliEvetHayır(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayırIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayırSeciliEvetHayır($"Seçtiğiniz {kartAdi} Silinecektir.Onaylıyor musunuz.?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaj()
        {
            return EvetSeciliEvetHayırIptal("Yapılan Değişiklikler Kayıt Edilsin mi.?", "Çıkış Onay");
        }

        public static DialogResult KayitMesaj()
        {
            return EvetSeciliEvetHayır("Yapılan Değişiklikler Kayıt Edilsin mi.?", "Kayıt Onay");
        }

        public static DialogResult TabloExportMesaj(string dosyaFormati)
        {
            return EvetSeciliEvetHayır($"İlgili Tablo, {dosyaFormati} Olarak Dışarı Aktarılacaktır. Onaylıyor musunuz.?", "Dosya Aktarım Onay");
        }

        public static DialogResult IptalMesaj(string kartAdi)
        {
            return HayırSeciliEvetHayır($"Seçtiğiniz {kartAdi} İptal Edilecektir.Onaylıyor musunuz.?", "İptal Onayı");
        }

        public static DialogResult IptalGeriAlMesaj(string kartAdi)
        {
            return HayırSeciliEvetHayır($"Seçtiğiniz {kartAdi} Kartına Uygulanan İptal İşlemi Geri Alınacaktır. Onaylıyor musunuz.?", "İptal Geri Al Onayı");
        }
    }
}
