using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class RehberBll : BaseGenelBll<Rehber>, IBaseGenelBll, IBaseCommonBll
    {
        public RehberBll() : base(KartTuru.Rehber) { }

        public RehberBll(Control control) : base(control, KartTuru.Rehber) { }
    }
}