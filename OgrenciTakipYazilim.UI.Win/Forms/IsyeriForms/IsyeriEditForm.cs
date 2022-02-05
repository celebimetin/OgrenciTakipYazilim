using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.IsyeriForms
{
    public partial class IsyeriEditForm : BaseEditForm
    {
        public IsyeriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new IsyeriBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Isyeri;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new Isyeri()
                : ((IsyeriBll)BllEdit).Single(FilterFunctions.Filter<Isyeri>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsyeriBll)BllEdit).YeniKodVer();
            txtIsyeriAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            Isyeri entity = (Isyeri)OldEntity;
            txtKod.Text = entity.Kod;
            txtIsyeriAdi.Text = entity.IsyeriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglIsyeriDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Isyeri()
            {
                Id = Id,
                Kod = txtKod.Text,
                IsyeriAdi = txtIsyeriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglIsyeriDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}