using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupEditForm : BaseEditForm
    {
        public SinifGrupEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new SinifGrupBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.SinifGrup;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new SinifGrup()
                : ((SinifGrupBll)BllEdit).Single(FilterFunctions.Filter<SinifGrup>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SinifGrupBll)BllEdit).YeniKodVer();
            txtGrupAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            SinifGrup entity = (SinifGrup)OldEntity;
            txtKod.Text = entity.Kod;
            txtGrupAdi.Text = entity.GrupAdi;
            txtAciklama.Text = entity.Aciklama;
            tglSinifGrupDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new SinifGrup()
            {
                Id = Id,
                Kod = txtKod.Text,
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglSinifGrupDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}