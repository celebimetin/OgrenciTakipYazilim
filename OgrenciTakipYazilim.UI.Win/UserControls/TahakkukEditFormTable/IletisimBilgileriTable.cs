using System;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.IletisimForms;
using OgrenciTakipYazilim.UI.Win.Forms.YakinlikForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();

            BllTablo = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnKartDuzenle };
            repositoryItemImageComboAdres.AddEnum<AdresTuru>();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((IletisimBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IletisimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriL>()
                .Where(x => !x.Delete)
                .Select(x => x.IletisimId).ToList();

            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayitlar, multiSelect: true, prm: false).EntityListConvert<IletisimL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId = entity.Id,
                    TcKimlikNo = entity.TcKimlikNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    EvTelefon = entity.EvTelefon,
                    IsTelefon1 = entity.IsTelefon1,
                    IsTelefon2 = entity.IsTelefon2,
                    CepTelefon1 = entity.CepTelefon1,
                    CepTelefon2 = entity.CepTelefon2,
                    EvAdres = entity.EvAdres,
                    EvAdresIlAdi = entity.EvAdresIlAdi,
                    EvAdresIlceAdi = entity.EvAdresIlceAdi,
                    IsAdres = entity.IsAdres,
                    IsAdresIlAdi = entity.IsAdresIlAdi,
                    IsAdresIlceAdi = entity.IsAdresIlceAdi,
                    IsyeriAdi = entity.IsyeriAdi,
                    MeslekAdi = entity.MeslekAdi,
                    GorevAdi = entity.GorevAdi,
                    Insert = true,
                };

                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.FaturaAdresi = AdresTuru.EvAdresi;
                }

                var yakinlik = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                if(yakinlik == null) return;
                row.YakinlikId = yakinlik.Id;
                row.YakinlikAdi = yakinlik.YakinlikAdi;

                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colTcKimlikNo;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);
                if (entity.YakinlikAdi == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colYakinlikAdi;
                    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosunda");
                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();

            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditFrom(KartTuru.Iletisim, entity.IletisimId, null);

        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if(source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                if(i == rowHandle) continue;
                if(source[i].FaturaAdresi == null) continue;
                source[i].FaturaAdresi = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                if (i == rowHandle) continue;
                if (!source[i].Veli) continue;
                source[i].Veli = false
;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if(e.FocusedColumn == colYakinlikAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryItemButtonYakinlik, colYakinlikId);
        }
    }
}
