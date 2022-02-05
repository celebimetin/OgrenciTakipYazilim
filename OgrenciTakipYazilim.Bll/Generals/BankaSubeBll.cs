using System.Windows.Forms;
using OgrenciTakipYazilim.Bll.Base;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;

namespace OgrenciTakipYazilim.Bll.Generals
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube) { }
        public BankaSubeBll(Control control) : base(control, KartTuru.BankaSube) { }
    }
}