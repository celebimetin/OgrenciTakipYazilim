using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Forms.IlceForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseListForm
    {
        private readonly long _bankaId;
        private readonly string _bankaAdi;

        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();
            BllList = new BankaSubeBll();
            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.BankaSube;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ({_bankaAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)BllList).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }
        protected override void ShowEditForm(long id)
        {
            long result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditFrom(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);
        }
    }
}