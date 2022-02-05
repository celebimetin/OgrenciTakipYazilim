using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class IptalNedeniBll : BaseGenelBll<IptalNedeni>, IBaseGenelBll, IBaseCommonBll
    {
        public IptalNedeniBll() : base(KartTuru.IptalNedeni) { }

        public IptalNedeniBll(Control control) : base(control, KartTuru.IptalNedeni) { }
    }
}