using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;

namespace OgrenciTakipYazilim.UI.Win.GenelForms
{
    public partial class RaporOnIzleme : RibbonForm
    {
        public RaporOnIzleme(params object[] prm)
        {
            InitializeComponent();

            raporDocumentViewer.PrintingSystem = (PrintingSystem)prm[0];
            Text = $"{Text} ( {prm[1].ToString()} )";
        }
    }
}