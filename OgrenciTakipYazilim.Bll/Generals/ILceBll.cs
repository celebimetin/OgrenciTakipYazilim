using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class ILceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public ILceBll() : base(KartTuru.Ilce) { }
        public ILceBll(Control control) : base(control, KartTuru.Ilce) { }
    }
}
