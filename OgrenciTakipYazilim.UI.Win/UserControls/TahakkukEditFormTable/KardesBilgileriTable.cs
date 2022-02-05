using System.Linq;
using DevExpress.XtraBars;
using OgrenciTakipYazilim.Bll.Functions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Forms.TahakkukForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    public partial class KardesBilgileriTable : BaseTablo
    {
        public KardesBilgileriTable()
        {
            InitializeComponent();

            BllTablo = new KardesBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource =
                ((KardesBilgileriBll)BllTablo).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<KardesBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KardesBilgileriL>()
                .Where(x => !x.Delete)
                .Select(x => x.KardesTahakkukId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);

            var entities = ShowListForms<TahakkukListForm>.ShowDialogListForm(KartTuru.Tahakkuk, ListeDisiTutulacakKayitlar, multiSelect: true, prm: false).EntityListConvert<TahakkukL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KardesBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    KardesTahakkukId = entity.Id,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    KayitSekli = entity.KayitSekli,
                    KayitDurumu = entity.KayitDurumu,
                    IptalDurumu = entity.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                    SubeAdi = entity.SubeAdi,
                    Insert = true,
                };
                source.Add(row);
            }
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButtonEnabledDurumu(true);
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<KardesBilgileriL>();

            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditFrom(KartTuru.Tahakkuk, entity.KardesTahakkukId, entity.SubeId == AnaForm.SubeId);

        }
    }
}
