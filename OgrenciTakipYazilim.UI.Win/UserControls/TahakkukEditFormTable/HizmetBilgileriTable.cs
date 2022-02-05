using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.HizmetForms;
using OgrenciTakipYazilim.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakipYazilim.UI.Win.Forms.OkulForms;
using OgrenciTakipYazilim.UI.Win.Forms.ServisForms;
using OgrenciTakipYazilim.UI.Win.Forms.TahakkukForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class HizmetBilgileriTable : BaseTablo
    {
        public HizmetBilgileriTable()
        {
            InitializeComponent();
            BllTablo = new HizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((HizmetBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<HizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<HizmetBilgileriL>()
                .Where(x => !x.IptalEdildi && !x.Delete)
                .Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, multiSelect: true, prm: true).EntityListConvert<HizmetL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                Servis servis = null;
                if (entity.HizmetTipi == HizmetTipi.Servis)
                {
                    servis = (Servis)ShowListForms<ServisListForm>.ShowDialogListForm(KartTuru.Servis, -1);
                    if (servis == null) continue;
                }

                var row = new HizmetBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    HizmetTuruId = entity.HizmetTuruId,
                    HizmetTipi = entity.HizmetTipi,
                    IslemTarihi = DateTime.Now.Date,
                    BaslamaTarihi = entity.BaslamaTarihi,
                    BurutUcret = entity.Ucret,
                    KistDonemDusulenUcret = 0,
                    IptalEdildi = false,
                    Insert = true,
                };

                if (servis != null)
                {
                    row.ServisId = servis.Id;
                    row.ServisYeriAdi = servis.ServisYeriAdi;
                    row.BurutUcret = servis.Ucret;
                }

                UcretHesapla(row);
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colHizmetAdi;

            ButtonEnabledDurumu(true);
        }

        protected override void HareketSil()
        {
            bool HizmetKartinaAitIptalEdilmiHareketVarmi(long hizmetId)
            {
                var count = tablo.DataController.ListSource.Cast<HizmetBilgileriL>().Count(x => x.HizmetId == hizmetId);
                return count < 2 && ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource
                       .Cast<IndirimBilgileriL>().Any(x => x.HizmetId == hizmetId && x.IptalEdildi);
            }

            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("Hizmet Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity.IptalEdildi)
            {
                Messages.IptalEdilenHareketSilinemezMesaj();
                return;
            }

            if (HizmetKartinaAitIptalEdilmiHareketVarmi(entity.HizmetId))
            {
                Messages.HataMesaji("Bu Hizmet Ait İptal Edilmiş İndirim Hareketleri Bulunmaktadır. Hizmet Kartı Silinemez.!");
                return;
            }

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluHareketSil(entity.HizmetId);
            entity.Delete = true;
            tablo.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            bool IndirimToplamHizmetToplamindenBuyuk(long hizmetId)
            {
                var hizmetToplami = tablo.DataController.ListSource.Cast<HizmetBilgileriL>()
                    .Where(x => x.HizmetId == hizmetId && !x.Delete).Sum(x => x.BurutUcret - x.KistDonemDusulenUcret);

                var indirimToplami = ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController
                    .ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.Delete)
                    .Sum(x => x.BurutIndirim - x.KistDonemDusulenIndirim);

                return indirimToplami > hizmetToplami;
            }

            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<HizmetBilgileriL>(i);

                if (entity.IptalEdildi && entity.HizmetTipi == HizmetTipi.Egitim && AnaForm.GittigiOkulZorunlu && entity.GittigiOkulId == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGittigiOkulAdi;
                    tablo.SetColumnError(colGittigiOkulAdi, "Gittiği Okul Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (entity.IptalEdildi && entity.IptalNedeniId == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colIptalNedeniAdi;
                    tablo.SetColumnError(colIptalNedeniAdi, "İptal Nedeni Alanına Geçerli Bir Değer Giriniz.");
                }

                if (tablo.HasColumnErrors)
                {
                    Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosunda");
                    return true;
                }

                if (IndirimToplamHizmetToplamindenBuyuk(entity.HizmetId))
                {
                    tablo.FocusedRowHandle = i;

                    Messages.HataMesaji($"{entity.HizmetAdi} Kartına Uygulanan İndirimlerin Toplamı Kartın Toplam Tutarını Aşmaktadır.");
                    return true;
                }
            }

            return false;
        }

        private void UcretHesapla(HizmetBilgileriL entity)
        {
            var egitimBaslamaTarihi = AnaForm.EgitimBaslamaTarihi;
            var egitimBitisTarihi = AnaForm.DonemBitisTarihi;

            var toplamGunSayisi = (int)(egitimBitisTarihi - egitimBaslamaTarihi).TotalDays + 1;
            var gunlukUcret = entity.BurutUcret / toplamGunSayisi;
            var alinanHizmetGunSayisi = entity.IptalTarihi == null
                ? (int)(egitimBitisTarihi - entity.BaslamaTarihi).TotalDays + 1
                : (int)(entity.IptalTarihi - entity.BaslamaTarihi).Value.TotalDays + 1;

            var odenecekUcret = alinanHizmetGunSayisi > 0 ? gunlukUcret * alinanHizmetGunSayisi : 0;
            var kistDonemDusulenUcret = entity.BurutUcret - odenecekUcret;

            kistDonemDusulenUcret = Math.Round(kistDonemDusulenUcret, AnaForm.HizmetTahakkukKurusKullan ? 2 : 0);

            if (entity.BaslamaTarihi > egitimBaslamaTarihi || entity.IptalEdildi)
                entity.KistDonemDusulenUcret = kistDonemDusulenUcret;
            else
                entity.KistDonemDusulenUcret = 0;

            entity.NetUcret = entity.BurutUcret - entity.KistDonemDusulenUcret;
            entity.EgitimDonemiGunSayisi = toplamGunSayisi;
            entity.AlinanHizmetGunSayisi = alinanHizmetGunSayisi;
            entity.GunlukUcret = gunlukUcret;
        }

        protected override void IptalEt()
        {
            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity == null || entity.IptalEdildi || entity.Insert) return;
            if (Messages.IptalMesaj("Hizmet Bilgisi") != DialogResult.Yes) return;

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                entity.IptalNedeniId = iptalNedeni.Id;
                entity.IptalNedeniAdi = iptalNedeni.IptalNedenAdi;
            }

            if (entity.HizmetTipi == HizmetTipi.Egitim)
            {
                var gittigiOkul = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, -1);
                if (gittigiOkul != null)
                {
                    entity.GittigiOkulId = gittigiOkul.Id;
                    entity.GittigiOkulAdi = gittigiOkul.OkulAdi;
                }
            }

            entity.IptalTarihi = DateTime.Now.Date;
            entity.HizmetAdi = $"{entity.HizmetAdi} - ( *** İptal Edildi *** )";
            entity.IptalEdildi = true;
            entity.Update = true;
            UcretHesapla(entity);

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalEt(entity);
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            tablo.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurumu(true);
        }

        protected override void IptalGeriAl()
        {
            bool AyniHizmetAlindi(long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<HizmetBilgileriL>()
                    .Any(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }

            var entity = tablo.GetRow<HizmetBilgileriL>();
            if (entity == null || !entity.IptalEdildi) return;

            if (Messages.IptalGeriAlMesaj(entity.HizmetAdi) != DialogResult.Yes) return;
            if (AyniHizmetAlindi(entity.HizmetId))
            {
                Messages.UyarıMesaji("İptal İşleminin Geri Alınması Durumunda Aynı Hizmetten Birden Fazla Alım Durumu Oluşuyor.");
                return;
            }

            //  - ( *** İptal Edildi *** ) bu alandaki karakter sayısını tamamı 27 olduğu için böğle bir rakam verildi.
            entity.HizmetAdi = entity.HizmetAdi.Remove(entity.HizmetAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.GittigiOkulId = null;
            entity.GittigiOkulAdi = null;
            entity.IptalAciklama = null;
            entity.Update = true;

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalGeriAl(entity.Id);
            UcretHesapla(entity);
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            ButtonEnabledDurumu(true);
        }

        protected override void SutunGizleGoster()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            if (entity.HizmetTipi == HizmetTipi.Servis)
            {
                colServisYeriAdi.Visible = true;
                colServisYeriAdi.VisibleIndex = 1;
            }
            else
            {
                colServisYeriAdi.Visible = false;
            }
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<HizmetBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colGittigiOkulAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi;

            if (entity.HizmetTipi != HizmetTipi.Egitim)
                colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (HizmetBilgileriL)tablo.GetRow(tablo.FocusedRowHandle);
            if (entity == null) return;

            btnHareketSil.Enabled = !entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryItemIptalNedeni, colIptalNedeniId);

            else if (e.FocusedColumn == colGittigiOkulAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryItemGittigiOkul, colGittigiOkulId);

            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<HizmetBilgileriL>();
                if (entity == null) return;

                repositoryItemIptalTarihi.MinValue = AnaForm.GununTarihininOncesineIptalTarihiGirilebilir
                    ? entity.BaslamaTarihi
                    : DateTime.Now.Date;
                repositoryItemIptalTarihi.MaxValue = AnaForm.GununTarihininSonrasınaIptalTarihiGirilebilir
                    ? AnaForm.DonemBitisTarihi.AddDays(-1)
                    : DateTime.Now.Date;
            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<HizmetBilgileriL>();

            if (e.Column == colIptalNedeniAdi)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id)
                    .ForEach(x => x.IptalNedeniId = entity.Id);

                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id)
                    .ForEach(x => x.IptalNedeniAdi = entity.IptalNedeniAdi);
            }
            else if (e.Column == colIptalAciklama)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id)
                    .ForEach(x => x.IptalAciklama = entity.IptalAciklama);
            }
            else if (e.Column == colIptalTarihi)
            {
                UcretHesapla(entity);

                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id)
                    .ForEach(x => x.IptalTarihi = entity.IptalTarihi);

                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIndirimHesapla();
            }
        }
    }
}