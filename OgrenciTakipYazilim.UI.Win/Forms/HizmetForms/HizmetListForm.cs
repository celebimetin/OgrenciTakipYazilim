using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Utils.Extensions;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        private readonly Expression<Func<Hizmet, bool>> _filter;

        public HizmetListForm()
        {
            InitializeComponent();
            BllList = new HizmetBll();

            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public HizmetListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var ustPanelGoster = (bool) prm[0];
                ustPanelControl.Visible = DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && ustPanelGoster;
            }

            _filter = x =>
                !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId &&
                x.DonemId == AnaForm.DonemId && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseListKartTuru = KartTuru.Hizmet;
            ShowForm = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla();
        }

        protected override void Listele()
        {
            var list = ((HizmetBll)BllList).List(_filter);
            Tablo.GridControl.DataSource = list;

            if(!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else 
                Messages.KartBulunamadiMesaj("Kart");
        }

        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GununTarihininOncesineHizmetBaslamaTarihiGirilebilir
                ? AnaForm.EgitimBaslamaTarihi
                : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi
                    ? AnaForm.EgitimBaslamaTarihi
                    : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GununTarihininSonrasınaHizmetBaslamaTarihiGirilebilir
                ? AnaForm.DonemBitisTarihi
                : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi
                    ? AnaForm.EgitimBaslamaTarihi
                    : DateTime.Now.Date > AnaForm.DonemBitisTarihi
                        ? AnaForm.DonemBitisTarihi
                        : DateTime.Now.Date;

            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.EgitimBaslamaTarihi
                ? AnaForm.EgitimBaslamaTarihi
                : DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemBitisTarihi
                    ? DateTime.Now.Date
                    : DateTime.Now.Date > AnaForm.DonemBitisTarihi
                        ? AnaForm.DonemBitisTarihi
                        : DateTime.Now.Date;

        }

        protected override void EntitySelect()
        {
            base.EntitySelect();
            if(MultiSelect)
                SelectedEntities.ForEach(x => ((HizmetL)x).BaslamaTarihi = txtHizmetBaslamaTarihi.DateTime.Date);
        }
    }
}