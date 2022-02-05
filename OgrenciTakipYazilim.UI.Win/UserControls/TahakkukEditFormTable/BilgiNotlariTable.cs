using System;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class BilgiNotlariTable : BaseTablo
    {
        public BilgiNotlariTable()
        {
            InitializeComponent();

            BllTablo = new BilgiNotlariBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((BilgiNotlariBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<BilgiNotlariL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new BilgiNotlariL
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now,
                BilgiNotu = null,
                Insert = true,
            };
            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colBilgiNotu;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<BilgiNotlariL>(i);

                if (string.IsNullOrEmpty(entity.BilgiNotu))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colBilgiNotu;
                    tablo.SetColumnError(colBilgiNotu, "Bilgi Notu Alanına Geçerli Bir Değer Giriniz.");
                }

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosunda");
                return true;
            }

            return false;
        }
    }
}
