using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Forms.EvrakForms;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.SinifForms
{
    public partial class SinifListForm : BaseListForm
    {
        public SinifListForm()
        {
            InitializeComponent();
            BllList = new SinifBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.Sinif;
            ShowForm = new ShowEditForms<SinifEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifBll)BllList).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId);
        }
    }
}