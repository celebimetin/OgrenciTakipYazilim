using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruEditForm : BaseEditForm
    {
        public HizmetTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new HizmetTuruBll(myDataLayoutControl);
            txtHizmetTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetTipi>());
            BaseEditKartTuru = KartTuru.HizmetTuru;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new HizmetTuru()
                : ((HizmetTuruBll)BllEdit).Single(FilterFunctions.Filter<HizmetTuru>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((HizmetTuruBll)BllEdit).YeniKodVer();
            txtHizmetTuruAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            HizmetTuru entity = (HizmetTuru)OldEntity;
            txtKod.Text = entity.Kod;
            txtHizmetTuruAdi.Text = entity.HizmetTuruAdi;
            txtHizmetTipi.SelectedItem = entity.HizmetTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglHizmetTuruDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new HizmetTuru()
            {
                Id = Id,
                Kod = txtKod.Text,
                HizmetTuruAdi = txtHizmetTuruAdi.Text,
                HizmetTipi = txtHizmetTipi.Text.GetEnum<HizmetTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglHizmetTuruDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}