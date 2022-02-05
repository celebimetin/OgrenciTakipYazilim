using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruEditForm : BaseEditForm
    {
        public IndirimTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new IndirimTuruBll();
            BaseEditKartTuru = KartTuru.IndirimTuru;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new IndirimTuru()
                : ((IndirimTuruBll) BllEdit).Single(FilterFunctions.Filter<IndirimTuru>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }

            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IndirimTuruBll) BllEdit).YeniKodVer();
            txtIndirimTuruAdı.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            IndirimTuru entity = (IndirimTuru) OldEntity;
            txtKod.Text = entity.Kod;
            txtIndirimTuruAdı.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglIndirimTuruDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IndirimTuru()
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimTuruAdi = txtIndirimTuruAdı.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglIndirimTuruDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}