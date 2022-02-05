using System;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class SinavBilgileriTable : BaseTablo
    {
        public SinavBilgileriTable()
        {
            InitializeComponent();

            BllTablo = new SinavBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((SinavBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<SinavBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new SinavBilgileriL
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now.Date,
                Insert = true
            };
            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colSinavAdi;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if(tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<SinavBilgileriL>(i);

                if (string.IsNullOrEmpty(entity.SinavAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colSinavAdi;
                    tablo.SetColumnError(colSinavAdi, "Sınav Adı Alanına Geçerli Bir Değer Giriniz.");
                }

                if (string.IsNullOrEmpty(entity.PuanTuru))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colPuanTuru;
                    tablo.SetColumnError(colPuanTuru, "Puan Türü Alanına Geçerli Bir Değer Giriniz.");
                }

                if(!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaj($"{tablo.ViewCaption} Tablosunda");
                return true;
            }

            return false;
        }
    }
}
