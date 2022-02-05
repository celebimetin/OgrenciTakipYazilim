using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            BllEdit = new ServisBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Servis
;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new Servis()
                : ((ServisBll)BllEdit).Single(FilterFunctions.Filter<Servis>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBll)BllEdit).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeriAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            Servis entity = (Servis)OldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeriAdi.Text = entity.ServisYeriAdi;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglServisDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis()
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeriAdi = txtServisYeriAdi.Text,
                Aciklama = txtAciklama.Text,
                Ucret = txtUcret.Value,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglServisDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((ServisBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((ServisBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}