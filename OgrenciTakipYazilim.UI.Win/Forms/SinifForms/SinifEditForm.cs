using System;
using DevExpress.XtraEditors;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.SinifForms
{
    public partial class SinifEditForm : BaseEditForm
    {
        public SinifEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new SinifBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Sinif;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new SinifS()
                : ((SinifBll)BllEdit).Single(FilterFunctions.Filter<Sinif>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifBll)BllEdit).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtSinifAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            SinifS entity = (SinifS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSinifAdi.Text = entity.SinifAdi;
            txtGrup.Id = entity.GrupId;
            txtGrup.Text = entity.GrupAdi;
            txtHedefOgSayisi.Value = entity.HedefOgrenciSayisi;
            txtHedefCiro.Value = entity.HedefCiro;
            txtAciklama.Text = entity.Aciklama;
            tglSinifDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sinif
            {
                Id = Id,
                Kod = txtKod.Text,
                SinifAdi = txtSinifAdi.Text,
                GrupId =Convert.ToInt64(txtGrup.Id),
                HedefOgrenciSayisi = (int)txtHedefOgSayisi.Value,
                HedefCiro = txtHedefCiro.Value,
                Aciklama = txtAciklama.Text,
                Durum = tglSinifDurum.IsOn,
                SubeId = AnaForm.SubeId,
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
                if (sender == txtGrup)
                {
                    sec.Sec(txtGrup);
                }
            }
        }
        protected override bool EntityInsert()
        {
            return ((SinifBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }
        protected override bool EntityUpdate()
        {
            return ((SinifBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }
    }
}