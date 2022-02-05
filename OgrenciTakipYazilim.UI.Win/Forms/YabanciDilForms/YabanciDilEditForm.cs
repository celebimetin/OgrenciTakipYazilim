using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.YabanciDilForms
{
    public partial class YabanciDilEditForm : BaseEditForm
    {
        public YabanciDilEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new YabanciDilBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.YabanciDil;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new YabanciDil()
                : ((YabanciDilBll)BllEdit).Single(FilterFunctions.Filter<YabanciDil>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YabanciDilBll)BllEdit).YeniKodVer();
            txtYabanciDilAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            YabanciDil entity = (YabanciDil)OldEntity;
            txtKod.Text = entity.Kod;
            txtYabanciDilAdi.Text = entity.YabanciDilAdi;
            txtAciklama.Text = entity.Aciklama;
            tglYabanciDilDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new YabanciDil()
            {
                Id = Id,
                Kod = txtKod.Text,
                YabanciDilAdi = txtYabanciDilAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglYabanciDilDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}