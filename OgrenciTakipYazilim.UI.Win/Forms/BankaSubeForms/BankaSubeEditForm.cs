using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeEditForm : BaseEditForm
    {
        private readonly long _bankaId;
        private readonly string _bankaAdi;

        public BankaSubeEditForm(params object[] prm)
        {
            InitializeComponent();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            BllEdit = new BankaSubeBll(myDataLayoutControl);
            BaseEditKartTuru = KartTuru.BankaSube;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new BankaSube()
                : ((BankaSubeBll)BllEdit).Single(FilterFunctions.Filter<BankaSube>(Id));

            NesneKontrollereBagla();

            Text = Text + $" - ( {_bankaAdi} )";

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaSubeBll)BllEdit).YeniKodVer(x => x.BankaId == _bankaId);
            txtBankaSubeAdi.Focus();
        }
        protected override void NesneKontrollereBagla()
        {
            BankaSube entity = (BankaSube)OldEntity;

            txtKod.Text = entity.Kod;
            txtBankaSubeAdi.Text = entity.SubeAdi;
            txtAciklama.Text = entity.Aciklama;
            tglBankaSubeDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaSube()
            {
                Id = Id,
                Kod = txtKod.Text,
                SubeAdi = txtBankaSubeAdi.Text,
                BankaId = _bankaId,
                Aciklama = txtAciklama.Text,
                Durum = tglBankaSubeDurum.IsOn
            };
            ButtonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((BankaSubeBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.BankaId == _bankaId);
        }
        protected override bool EntityUpdate()
        {
            return ((BankaSubeBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.BankaId == _bankaId);
        }
    }
}