using System;
using DevExpress.XtraEditors;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.IndirimForms
{
    public partial class IndirimEditForm : BaseEditForm
    {
        public IndirimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new IndirimBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Indirim;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new IndirimS()
                : ((IndirimBll)BllEdit).Single(FilterFunctions.Filter<Indirim>(Id));

            NesneKontrollereBagla();
            TabloYukle();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IndirimBll)BllEdit).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtIndirimAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            IndirimS entity = (IndirimS)OldEntity;

            txtKod.Text = entity.Kod;
            txtIndirimAdi.Text = entity.IndirimAdi;
            txtIndirimTuru.Id = entity.IndirimTuruId;
            txtIndirimTuru.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglIndirimDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Indirim()
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimAdi = txtIndirimAdi.Text,
                IndirimTuruId = Convert.ToInt64(txtIndirimTuru.Id),
                Aciklama = txtAciklama.Text,
                Durum = tglIndirimDurum.IsOn,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId
            };
            ButtonEnabledDurumu();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!Isloaded) return;
            GeneralFunctionsWin.ButtonEnabledDurumu(btnKaydet, btnGeriAl, btnYeni, btnSil, OldEntity, CurrentEntity, indirimHizmetTablo.TableValueChanged);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
            {
                return;
            }
            using (var sec = new SelectFunctions())
            {
                if (sender == txtIndirimTuru)
                {
                    sec.Sec(txtIndirimTuru);
                }
            }
        }

        protected override bool EntityInsert()
        {
            if (indirimHizmetTablo.HataliGiris()) return false;

            return ((IndirimBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && indirimHizmetTablo.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (indirimHizmetTablo.HataliGiris()) return false;

            return ((IndirimBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && indirimHizmetTablo.Kaydet();
        }

        protected override void TabloYukle()
        {
            indirimHizmetTablo.OwnerForm = this;
            indirimHizmetTablo.Yukle();
        }
    }
}