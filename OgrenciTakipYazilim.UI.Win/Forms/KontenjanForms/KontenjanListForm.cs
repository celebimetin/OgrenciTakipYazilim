using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Forms.TesvikForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseListForm
    {
        public KontenjanListForm()
        {
            InitializeComponent();
            BllList = new KontenjanBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.Kontenjan;
            ShowForm = new ShowEditForms<KontenjanEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KontenjanBll)BllList).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
        }
    }
}