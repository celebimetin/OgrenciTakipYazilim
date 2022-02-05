using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.IptalNedeniForms
{
    public partial class IptalNedeniEditForm : BaseEditForm
    {
        public IptalNedeniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new IptalNedeniBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.IptalNedeni;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new IptalNedeni()
                : ((IptalNedeniBll)BllEdit).Single(FilterFunctions.Filter<IptalNedeni>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IptalNedeniBll)BllEdit).YeniKodVer();
            txtIptalNedenAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            IptalNedeni entity = (IptalNedeni)OldEntity;
            txtKod.Text = entity.Kod;
            txtIptalNedenAdi.Text = entity.IptalNedenAdi;
            txtAciklama.Text = entity.Aciklama;
            tglIptalNedenDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IptalNedeni()
            {
                Id = Id,
                Kod = txtKod.Text,
                IptalNedenAdi = txtIptalNedenAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglIptalNedenDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
    }
}