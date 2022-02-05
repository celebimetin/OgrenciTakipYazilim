using DevExpress.XtraEditors;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.CariForms
{
    public partial class CariEditForm : BaseEditForm
    {
        public CariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new CariBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.Cari;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new CariS()
                : ((CariBll)BllEdit).Single(FilterFunctions.Filter<Cari>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)BllEdit).YeniKodVer();
            txtCariAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            CariS entity = (CariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtTelefon3.Text = entity.Telefon3;
            txtTelefon4.Text = entity.Telefon4;
            txtFax.Text = entity.Fax;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.Adres;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglCariDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Cari()
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Telefon3 = txtTelefon3.Text,
                Telefon4 = txtTelefon4.Text,
                Fax = txtFax.Text,
                Web = txtWeb.Text,
                Email = txtEmail.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                Adres = txtAdres.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglCariDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
            {
                return;
            }
            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Cari);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Cari);
                }
            }
        }
    }
}