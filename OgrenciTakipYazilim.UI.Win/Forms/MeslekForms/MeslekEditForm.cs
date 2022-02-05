using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.MeslekForms
{
    public partial class MeslekEditForm : BaseEditForm
    {
        public MeslekEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new MeslekBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Meslek;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new Meslek()
                : ((MeslekBll)BllEdit).Single(FilterFunctions.Filter<Meslek>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MeslekBll)BllEdit).YeniKodVer();
            txtMeslekAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            Meslek entity = (Meslek)OldEntity;
            txtKod.Text = entity.Kod;
            txtMeslekAdi.Text = entity.MeslekAdi;
            txtAciklama.Text = entity.Aciklama;
            tglMeslekDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Meslek()
            {
                Id = Id,
                Kod = txtKod.Text,
                MeslekAdi = txtMeslekAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglMeslekDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}