using System;
using DevExpress.XtraEditors;
using OgrenciTakipYazilim.Bll.Generals;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.GenelForms;

namespace OgrenciTakipYazilim.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            BllEdit = new BankaHesapBll(myDataLayoutControl);
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            BaseEditKartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseEditIslemTuru == IslemTuru.EntityInsert
                ? new BankaHesapS()
                : ((BankaHesapBll)BllEdit).Single(FilterFunctions.Filter<BankaHesap>(Id));

            NesneKontrollereBagla();

            if (BaseEditIslemTuru != IslemTuru.EntityInsert)
            {
                return;
            }
            Id = BaseEditIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)BllEdit).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        protected override void NesneKontrollereBagla()
        {
            BankaHesapS entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi.Date;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsyeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglBankaHesapDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsyeriNo = txtIsyeriNo.Text,
                TerminalNo = txtTerminalNo.Text,
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime.Date,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglBankaHesapDurum.IsOn
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
                if (sender == txtBanka)
                {
                    sec.Sec(txtBanka);
                }
                else if (sender == txtBankaSube)
                {
                    sec.Sec(txtBankaSube, txtBanka);
                }
                else if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
                }
            }
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)BllEdit).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)BllEdit).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void ControlMyButtonEdit_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka)
            {
                return;
            }
            txtBanka.ControlEnabledChange(txtBankaSube);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;
            
            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();
            if (hesapTuru == BankaHesapTuru.EposBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsyeriNo.Enabled = true;
                txtTerminalNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtBlokeGunSayisi.Value = 0;
                txtIsyeriNo.Enabled = false;
                txtIsyeriNo.Text = null;
                txtTerminalNo.Enabled = false;
                txtTerminalNo.Text = null;
            }
        }
    }
}