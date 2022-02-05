using System.Linq;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Forms.HizmetForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.IndirimEditFormTable
{
    public partial class IndirimUygulanacakHizmetTable : BaseTablo
    {
        public IndirimUygulanacakHizmetTable()
        {
            InitializeComponent();

            BllTablo = new IndirimUygulamaHizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((IndirimUygulamaHizmetBilgileriBll) BllTablo).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndirimUygulamaHizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndirimUygulamaHizmetBilgileriL>()
                .Where(x => !x.Delete)
                .Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, multiSelect:true, prm:false).EntityListConvert<HizmetL>();
            if(entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IndirimUygulamaHizmetBilgileriL
                {
                    IndirimId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutar = 0,
                    IndirimOran = 0,
                    SubeId = AnaForm.SubeId,
                    DonemId = AnaForm.DonemId,
                    Insert = true,
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIndirimTutari;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            for (int i = 0; i < tablo.RowCount; i++)
            {
                var entity = tablo.GetRow<IndirimUygulamaHizmetBilgileriL>(i);
                if(entity.IndirimTutar == 0 || entity.IndirimOran == 0) continue;
                tablo.Focus();
                tablo.FocusedRowHandle = i;
                Messages.HataMesaji("İndirim Tutarı veya İndirim Oranları alanlarından birisi sıfırdan büyük olmalıdır.");

                return true;
            }

            return false;
        }
    }
}