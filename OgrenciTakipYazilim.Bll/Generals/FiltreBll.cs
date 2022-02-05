using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class FiltreBll : BaseGenelBll<Filtre>, IBaseCommonBll
    {
        public FiltreBll() : base(KartTuru.Filtre) { }
        public FiltreBll(Control control) : base(control, KartTuru.Filtre) { }
    }
}
