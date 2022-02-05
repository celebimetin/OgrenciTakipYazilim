using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly GridControl _filtreGrid;
        private readonly KartTuru _filtreKartTuru;

        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            BllList = new FiltreBll();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[]
            {
                btnFiltrele,
                barFiltrele,
                barFiltreleAciklama,
                btnKolonlar,
                barKolonlar,
                barKolonlarAciklama,
                btnYazdir,
                barYazdir,
                barYazdirAciklama,
                btnGonder,
                barGonder,
                barGonderAciklama,
            };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.Filtre;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)BllList).List(x => x.KartTuru == _filtreKartTuru);
        }
        protected override void ShowEditForm(long id)
        {
            long result = ShowEditForms<FiltreEditForm>.ShowDialogEditFrom(KartTuru.Filtre, id, _filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);
        }
    }
}