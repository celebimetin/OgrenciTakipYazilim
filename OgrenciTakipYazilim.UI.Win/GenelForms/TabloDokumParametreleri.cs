using System;
using DevExpress.XtraBars;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.GenelForms
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;

        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGeriAl, btnSil };
            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnizleme };
            EventsLoad();

            _raporBaslik = prm[0].ToString();
        }
        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _raporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklari.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctionsWin.YazicileriListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporKagidaSigdir.SelectedItem = RaporKagidaSigdirmaTuru.YaziBoyutKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgi.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgi.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklari.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.SelectedItem = GeneralFunctionsWin.DefaultYazici();
        }
        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporKagidaSigdirmaTuru = txtRaporKagidaSigdir.Text.GetEnum<RaporKagidaSigdirmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgi.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgi.Text.GetEnum<EvetHayir>(),
                SutunBaslikGoster = txtSutunBasliklari.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirmaAdet.Value,
                DokumSekli = _dokumSekli
            };
            return entity;
        }
        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }
        protected override void BaskiOnIzleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnİzleme;
            Close();
        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
                txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}