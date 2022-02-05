using DevExpress.XtraGrid.Views.Base;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class EposBilgileriTable : BaseTablo
    {
        public EposBilgileriTable()
        {
            InitializeComponent();

            BllTablo = new EposBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            repositoryItemImageComboBoxKartTuru.Items.AddEnum<EposKartTuru>();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((EposBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EposBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            var row = new EposBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Insert = true,
            };
            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<EposBilgileriL>(i);

                if (string.IsNullOrEmpty(entity.Adi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colAdi;
                    tablo.SetColumnError(colAdi, "Kart Sahibinin Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.Soyadi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSoyadi;
                    tablo.SetColumnError(colSoyadi, "Kart Sahibinin Soyadı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.BankaAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBankaAdi;
                    tablo.SetColumnError(colBankaAdi, "Banka Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.KartNo))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colKartNo;
                    tablo.SetColumnError(colKartNo, "Kart Numarası Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.SonkullanmaTarihi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSonkullanmaTarihi;
                    tablo.SetColumnError(colSonkullanmaTarihi, "Son Kullanma Tarihi Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.GuvenlikKod))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colGuvenlikKod;
                    tablo.SetColumnError(colGuvenlikKod, "Güvenlik Kodu Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosunda");
                return true;
            }

            return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaAdi)
                e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryItemButtonBanka, colBankaId);
        }
    }
}
