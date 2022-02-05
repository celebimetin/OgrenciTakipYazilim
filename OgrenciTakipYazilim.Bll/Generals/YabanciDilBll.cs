using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class YabanciDilBll : BaseGenelBll<YabanciDil>, IBaseGenelBll, IBaseCommonBll
    {
        public YabanciDilBll() : base(KartTuru.YabanciDil) { }

        public YabanciDilBll(Control control) : base(control, KartTuru.YabanciDil) { }
    }
}