using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        private readonly Expression<Func<AileBilgi, bool>> _filter;

        public AileBilgiListForm()
        {
            InitializeComponent();
            BllList = new AileBilgiBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public AileBilgiListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.AileBilgi;
            ShowForm = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((AileBilgiBll)BllList).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaj("Kart");
        }
    }
}