using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev) { }

        public GorevBll(Control control) : base(control, KartTuru.Gorev) { }
    }
}