using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class SinifGrupBll : BaseGenelBll<SinifGrup>, IBaseGenelBll, IBaseCommonBll
    {
        public SinifGrupBll() : base(KartTuru.SinifGrup) { }

        public SinifGrupBll(Control control) : base(control, KartTuru.SinifGrup) { }
    }
}