using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();

            BllList = new ILceBll();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ({_ilAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ILceBll)BllList).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }
        protected override void ShowEditForm(long id)
        {
            long result =ShowEditForms<IlceEditForm>.ShowDialogEditFrom(KartTuru.Ilce, id, _ilId, _ilAdi);
            ShowEditFormDefault(result);
        }
    }
}