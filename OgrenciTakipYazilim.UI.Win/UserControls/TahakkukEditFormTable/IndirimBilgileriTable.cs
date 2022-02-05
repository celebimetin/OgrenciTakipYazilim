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
using OgrenciTakipYazilim.UI.Win.Forms.IndirimForms;
using OgrenciTakipYazilim.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakipYazilim.UI.Win.Forms.TahakkukForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class IndirimBilgileriTable : BaseTablo
    {
        public IndirimBilgileriTable()
        {
            InitializeComponent();
            BllTablo = new IndirimBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((IndirimBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IndirimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            bool HizmetAlindi(long hizmetId)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm)
                    .hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete)
                    .Sum(x => x.BurutUcret);

                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete).Sum(x => x.BurutIndirim);

                return hizmetToplami != 0 && hizmetToplami - indirimToplami > 0;
            }

            bool AyniHizmetKartinaAyniIndirimUygulandi(IndirimUygulamaHizmetBilgileriL hizmet)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Any(x =>
                    x.HizmetId == hizmet.Id && x.IndirimId == hizmet.IndirimId && !x.ManuelGirilenTutar &&
                    !x.IptalEdildi && !x.Delete);
            }

            var indirimList = ShowListForms<IndirimListForm>.ShowDialogListForm(KartTuru.Indirim, multiSelect: true)
                .EntityListConvert<IndirimL>();
            if (indirimList == null) return;

            using (var bll = new IndirimUygulamaHizmetBilgileriBll())
            {
                var soucre = tablo.DataController.ListSource;
                var sabitTutarliIndirimGirildi = false;
                var eklenenKayitSayisi = 0;

                foreach (var indirim in indirimList)
                {
                    var hizmetList = bll.List(x =>
                        x.IndirimId == indirim.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId).Cast<IndirimUygulamaHizmetBilgileriL>();

                    foreach (var hizmet in hizmetList)
                    {
                        if (!HizmetAlindi(hizmet.HizmetId)) continue;
                        if (AyniHizmetKartinaAyniIndirimUygulandi(hizmet)) continue;

                        if (!sabitTutarliIndirimGirildi)
                            sabitTutarliIndirimGirildi = hizmet.IndirimTutar > 0;

                        var (burutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);

                        var row = new IndirimBilgileriL
                        {
                            TahakkukId = OwnerForm.Id,
                            IndirimId = indirim.Id,
                            IndirimAdi = indirim.IndirimAdi,
                            HizmetId = hizmet.HizmetId,
                            HizmetAdi = hizmet.HizmetAdi,
                            IslemTarihi = DateTime.Now.Date,
                            BurutIndirim = burutIndirim,
                            KistDonemDusulenIndirim = kistDonemDusulenIndirim,
                            NetIndirim = burutIndirim - kistDonemDusulenIndirim,
                            OranliIndirim = hizmet.IndirimOran > 0,
                            ManuelGirilenTutar = hizmet.IndirimOran == 0 && hizmet.IndirimTutar == 0,
                            Insert = true
                        };

                        soucre.Add(row);
                        eklenenKayitSayisi++;

                        if (hizmet.IndirimOran == 0 && hizmet.IndirimTutar == 0)
                            tablo.FocusedColumn = colBurutIndirim;
                    }
                }

                if (eklenenKayitSayisi == 0) return;
                if (sabitTutarliIndirimGirildi)
                    TopluIndirimHesapla();
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);

            ButtonEnabledDurumu(true);
        }

        private (decimal burutIndirim, decimal kistDonemDusulenIndirim) IndirimHesapla(long indirimId, long hizmetId)
        {
            decimal HizmetToplamiAl(bool iptalEdildi)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().Where(x => x.HizmetId == hizmetId && x.IptalEdildi == iptalEdildi && !x.Delete)
                    .Sum(x => x.BurutUcret);

                var indirimToplami = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x =>
                    x.HizmetId == hizmetId && !x.ManuelGirilenTutar && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BurutIndirim);

                return hizmetToplami == 0 ? 0 : hizmetToplami - indirimToplami;
            }

            using (var bll = new IndirimUygulamaHizmetBilgileriBll())
            {
                var hizmetSource = bll.List(x => x.IndirimId == indirimId && x.HizmetId == hizmetId)
                    .Cast<IndirimUygulamaHizmetBilgileriL>()
                    .FirstOrDefault();
                if (hizmetSource == null) return (0, 0);

                var egitimBitisTarihi = AnaForm.DonemBitisTarihi;

                var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().First(x => x.HizmetId == hizmetId && !x.Delete);

                var indirimEntity = tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .FirstOrDefault(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.Delete);

                var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(true) : HizmetToplamiAl(false);
                var toplamGunSayisi = hizmetEntity.EgitimDonemiGunSayisi;
                var hizmetGunSayisi = indirimEntity?.IptalTarihi == null
                    ? (int)(egitimBitisTarihi - hizmetEntity.BaslamaTarihi).TotalDays + 1
                    : (int)(indirimEntity.IptalTarihi - hizmetEntity.BaslamaTarihi).Value.TotalDays + 1;
                var burutIndirim = hizmetSource.IndirimTutar > 0
                    ? hizmetSource.IndirimTutar
                    : hizmetToplami * hizmetSource.IndirimOran / 100;

                var gunlukIndirim = burutIndirim / toplamGunSayisi;
                var kistDonemDusulenIndirim = (toplamGunSayisi - hizmetGunSayisi) * gunlukIndirim;
                burutIndirim = Math.Round(burutIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

                return (burutIndirim, kistDonemDusulenIndirim);
            }
        }

        protected internal void TopluIndirimHesapla()
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().ToList();

            source.ForEach(x =>
            {
                if (!x.OranliIndirim || x.ManuelGirilenTutar || x.Delete) return;
                x.BurutIndirim = 0;
                x.KistDonemDusulenIndirim = 0;
            });

            source.ForEach(x =>
            {
                if (x.ManuelGirilenTutar || x.Delete) return;

                var (burutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(x.IndirimId, x.HizmetId);
                x.BurutIndirim = burutIndirim;
                x.KistDonemDusulenIndirim = kistDonemDusulenIndirim;
                x.NetIndirim = burutIndirim - kistDonemDusulenIndirim;

                if (!x.Insert) x.Update = true;
            });

            tablo.UpdateSummary();
        }

        protected override void HareketSil()
        {
            if (tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if (entity.IptalEdildi)
            {
                Messages.IptalEdilenHareketSilinemezMesaj();
                return;
            }

            entity.Delete = true;
            tablo.RefreshDataSource();
            TopluIndirimHesapla();
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluHareketSil(long hizmetId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            var silinenKayitVarmi = false;

            source.ForEach(x =>
            {
                if (x.IptalEdildi || x.HizmetId != hizmetId) return;
                x.Delete = true;
                silinenKayitVarmi = true;
            });

            if (silinenKayitVarmi)
                tablo.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected override void IptalEt()
        {
            var indirimEntity = tablo.GetRow<IndirimBilgileriL>();
            if (indirimEntity == null || indirimEntity.IptalEdildi || indirimEntity.Insert) return;
            if (Messages.IptalMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                .Cast<HizmetBilgileriL>().FirstOrDefault(x => !x.IptalEdildi && x.HizmetId == indirimEntity.HizmetId);
            if (hizmetEntity == null) return;

            var gunlukIndirim = indirimEntity.BurutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
            var alinanHizmetGunSayisi = (int)(DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
            var burutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
            var kistDonemDusulenIndirim = indirimEntity.BurutIndirim - burutIndirim;
            kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                indirimEntity.IptalNedeniId = iptalNedeni.Id;
                indirimEntity.IptalNedeniAdi = iptalNedeni.IptalNedenAdi;
            }

            indirimEntity.IndirimAdi = $"{indirimEntity.IndirimAdi} - ( *** İptal Edildi *** )";
            if (!indirimEntity.ManuelGirilenTutar)
                indirimEntity.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
            indirimEntity.NetIndirim = indirimEntity.BurutIndirim - indirimEntity.KistDonemDusulenIndirim;
            indirimEntity.IptalTarihi = DateTime.Now.Date;
            indirimEntity.IptalEdildi = true;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            tablo.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluIptalEt(HizmetBilgileriL entity)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>();
            if (source == null) return;

            source.ForEach(x =>
            {
                if (x.HizmetId != entity.HizmetId || x.IptalEdildi) return;

                var gunlukIndirim = x.BurutIndirim / entity.EgitimDonemiGunSayisi;
                var burutIndirim = gunlukIndirim * entity.AlinanHizmetGunSayisi;
                var kistDonemDusulenIndirim = x.BurutIndirim - burutIndirim;
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.IndirimTahakkukKurusKullan ? 2 : 0);

                x.IndirimAdi = $"{x.IndirimAdi} - ( *** İptal Edildi *** )";
                if (!x.ManuelGirilenTutar)
                    x.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
                x.NetIndirim = x.BurutIndirim - x.KistDonemDusulenIndirim;
                x.IptalTarihi = DateTime.Now.Date;
                x.IptalEdildi = true;
                x.HizmetHareketId = entity.Id;
                x.IptalNedeniId = entity.IptalNedeniId;
                x.IptalNedeniAdi = entity.IptalNedeniAdi;
                if (!x.Insert) x.Update = true;
            });

            TopluIndirimHesapla();
            tablo.UpdateSummary();
        }

        protected override void IptalGeriAl()
        {
            bool HizmetAlindi(long hizmetId)
            {
                return ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource
                    .Cast<HizmetBilgileriL>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi);
            }

            bool AyniIndirimAlindi(long indirimId, long hizmetId)
            {
                return tablo.DataController.ListSource.Cast<IndirimBilgileriL>()
                    .Any(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }

            var entity = tablo.GetRow<IndirimBilgileriL>();
            if (entity == null || !entity.IptalEdildi) return;
            if (Messages.IptalGeriAlMesaj(entity.IndirimAdi) != DialogResult.Yes) return;

            if (entity.HizmetHareketId == null && !HizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İndirim Uygulandığı Hizmet İptal Edilmiş İptal Edilen Hizmet Kartı Geri Alınmadan veya Yeni Bir Hizmet Alınmadan İptal İşlemi Geri Alınamaz.");
                return;
            }

            if (entity.HizmetHareketId != null)
            {
                Messages.HataMesaji("İptal Edilen İndirim, Hizmet Hareketleri Tablosunda Geri Alınabilir.");
                return;
            }

            if (AyniIndirimAlindi(entity.IndirimId, entity.HizmetId))
            {
                Messages.HataMesaji("İptal İşleminin Geri Alınması Durumunda Aynı İndirimden Birden Fazla Alım Durumu Oluşuyor.");
                return;
            }

            //  - ( *** İptal Edildi *** ) bu alandaki karakter sayısını tamamı 27 olduğu için böğle bir rakam verildi.
            entity.IndirimAdi = entity.IndirimAdi.Remove(entity.IndirimAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.IptalAciklama = null;
            entity.HizmetHareketId = null;
            entity.Update = true;

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
            tablo.RowCellEnabled();
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluIptalGeriAl(int hizmetHareketId)
        {
            var source = tablo.DataController.ListSource.Cast<IndirimBilgileriL>().Where(x => x.HizmetHareketId == hizmetHareketId);
            source.ForEach(x =>
            {
                //  - ( *** İptal Edildi *** ) bu alandaki karakter sayısını tamamı 27 olduğu için böğle bir rakam verildi.
                x.IndirimAdi = x.IndirimAdi.Remove(x.IndirimAdi.Length - 27, 27);
                x.IptalEdildi = false;
                x.IptalTarihi = null;
                x.IptalNedeniId = null;
                x.IptalNedeniAdi = null;
                x.IptalAciklama = null;
                x.HizmetHareketId = null;
                x.Update = true;
            });

            TopluIndirimHesapla();
            tablo.RefreshDataSource();
            tablo.UpdateSummary();
        }

        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var entity = tablo.GetRow<IndirimBilgileriL>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;

            if (entity.Insert)
            {
                colBurutIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && entity.IptalEdildi;
            }
            else
            {
                colBurutIndirim.OptionsColumn.AllowEdit = false;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar;
            }
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (IndirimBilgileriL)tablo.GetRow(tablo.FocusedRowHandle);
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

            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                if (entity == null) return;

                repositoryItemIptalTarih.MinValue = AnaForm.GununTarihininOncesineIptalTarihiGirilebilir
                    ? entity.IslemTarihi
                    : DateTime.Now.Date;
                repositoryItemIptalTarih.MaxValue = AnaForm.GununTarihininSonrasınaIptalTarihiGirilebilir
                    ? AnaForm.DonemBitisTarihi.AddDays(-1)
                    : DateTime.Now.Date;
            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colIptalTarihi)
                TopluIndirimHesapla();

            else if (e.Column == colBurutIndirim || e.Column == colKistDonemDusulenIndirim)
            {
                var entity = tablo.GetRow<IndirimBilgileriL>();
                entity.NetIndirim = entity.BurutIndirim - entity.KistDonemDusulenIndirim;
            }
        }

    }
}
