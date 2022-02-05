using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikEditForm : BaseEditForm
    {
        public YakinlikEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            BllEdit = new YakinlikBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Yakinlik;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new Yakinlik()
                : ((YakinlikBll)BllEdit).Single(FilterFunctions.Filter<Yakinlik>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YakinlikBll)BllEdit).YeniKodVer();
            txtYakinlikAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            Yakinlik entity = (Yakinlik)OldEntity;
            txtKod.Text = entity.Kod;
            txtYakinlikAdi.Text = entity.YakinlikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglYakinlikDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Yakinlik()
            {
                Id = Id,
                Kod = txtKod.Text,
                YakinlikAdi = txtYakinlikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglYakinlikDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}