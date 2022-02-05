using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Forms.FiltreForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.OzelKodForms
{
    public partial class OzelKodListForm : BaseListForm
    {
        private readonly OzelKodTuru _ozelKodTuru;
        private readonly KartTuru _ozelKodKartTuru;

        public OzelKodListForm(params object[] prm)
        {
            InitializeComponent();
            BllList = new OzelKodBll();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru) prm[1];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.OzelKod;
            Navigator = longNavigator.Navigator;
            Text = $"{Text} - ( {_ozelKodTuru.ToName()} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OzelKodBll)BllList).List(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }
        protected override void ShowEditForm(long id)
        {
            long result = ShowEditForms<OzelKodEditForm>.ShowDialogEditFrom(KartTuru.OzelKod, id, _ozelKodTuru, _ozelKodKartTuru);
            ShowEditFormDefault(result);
        }
    }
}