using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class KontenjanBll : BaseGenelBll<Kontenjan>, IBaseGenelBll, IBaseCommonBll
    {
        public KontenjanBll() : base(KartTuru.Kontenjan) { }

        public KontenjanBll(Control control) : base(control, KartTuru.Kontenjan) { }
    }
}