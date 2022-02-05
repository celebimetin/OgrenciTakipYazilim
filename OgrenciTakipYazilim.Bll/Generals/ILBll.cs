using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class ILBll : BaseGenelBll<Il>, IBaseGenelBll, IBaseCommonBll
    {
        public ILBll() : base(KartTuru.Il) { }
        public ILBll(Control control) : base(control, KartTuru.Il) { }
    }
}
