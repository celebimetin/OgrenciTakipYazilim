using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class OdemeTuruBll : BaseGenelBll<OdemeTuru>, IBaseGenelBll ,IBaseCommonBll
    {
        public OdemeTuruBll() : base(KartTuru.OdemeTuru) { }
        public OdemeTuruBll(Control control) : base(control, KartTuru.OdemeTuru) { }
    }
}