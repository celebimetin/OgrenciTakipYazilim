using System;
using DevExpress.XtraEditors;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.HizmetForms
{
    public partial class HizmetEditForm : BaseEditForm
    {
        public HizmetEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new HizmetBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Hizmet;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new HizmetS()
                : ((HizmetBll)BllEdit).Single(FilterFunctions.Filter<Hizmet>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((HizmetBll)BllEdit).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtBaslangicTarihi.DateTime = txtBaslangicTarihi.Properties.MinValue;
            txtBitisTarihi.DateTime = txtBitisTarihi.Properties.MaxValue;
            txtHizmetAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            HizmetS entity = (HizmetS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHizmetAdi.Text = entity.HizmetAdi;
            txtHizmetTuru.Id = entity.HizmetTuruId;
            txtHizmetTuru.Text = entity.HizmetTuruAdi;
            txtBaslangicTarihi.DateTime = entity.BaslamaTarihi;
            txtBitisTarihi.DateTime = entity.BitisTarihi;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglHizmetDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Hizmet()
            {
                Id = Id,
                Kod = txtKod.Text,
                HizmetAdi = txtHizmetAdi.Text,
                HizmetTuruId = Convert.ToInt64(txtHizmetTuru.Id),
                BaslamaTarihi = txtBaslangicTarihi.DateTime.Date,
                BitisTarihi = txtBitisTarihi.DateTime.Date,
                Ucret = txtUcret.Value,
                Aciklama = txtAciklama.Text,
                Durum = tglHizmetDurum.IsOn,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId
            };
            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
            {
                return;
            }

            using (var sec = new SelectFunctions())
            {
                if (sender == txtHizmetTuru)
                {
                    sec.Sec(txtHizmetTuru);
                }
            }
        }

        protected override bool EntityInsert()
        {
            return ((HizmetBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((HizmetBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);

            txtBaslangicTarihi.Properties.MinValue = AnaForm.EgitimBaslamaTarihi;
            txtBaslangicTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;
            txtBitisTarihi.Properties.MinValue = txtBaslangicTarihi.DateTime.Date;
            txtBitisTarihi.Properties.MaxValue = AnaForm.DonemBitisTarihi;
        }
    }
}