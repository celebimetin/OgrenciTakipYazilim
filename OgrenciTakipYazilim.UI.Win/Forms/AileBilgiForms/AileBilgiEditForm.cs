using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiEditForm : BaseEditForm
    {
        public AileBilgiEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new AileBilgiBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.AileBilgi;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new AileBilgi()
                : ((AileBilgiBll)BllEdit).Single(FilterFunctions.Filter<AileBilgi>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AileBilgiBll)BllEdit).YeniKodVer();
            txtAileBilgiAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            AileBilgi entity = (AileBilgi) OldEntity;
            txtKod.Text = entity.Kod;
            txtAileBilgiAdi.Text = entity.BilgiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglAlieBilgiDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new AileBilgi()
            {
                Id = Id,
                Kod = txtKod.Text,
                BilgiAdi = txtAileBilgiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglAlieBilgiDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}