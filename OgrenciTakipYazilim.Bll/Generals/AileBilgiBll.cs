using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class AileBilgiBll : BaseGenelBll<AileBilgi>, IBaseGenelBll, IBaseCommonBll
    {
        public AileBilgiBll() : base(KartTuru.AileBilgi) { }
        public AileBilgiBll(Control control) : base(control, KartTuru.AileBilgi) { }
    }
}