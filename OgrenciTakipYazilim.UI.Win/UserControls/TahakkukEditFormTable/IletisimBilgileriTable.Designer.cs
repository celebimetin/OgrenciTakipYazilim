namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class IletisimBilgileriTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.tablo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVeli = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemCheckVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFaturaAdresi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemImageComboAdres = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colYakinlikAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemButtonYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTcKimlikNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMeslekAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEvTelefon = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCepTelefon1 = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsTelefon1 = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEvAdres = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresIlAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresIlceAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsAdres = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresIlAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresIlceAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsyeriAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGorevAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colYakinlikId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckVeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonYakinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonYakinlik,
            this.repositoryItemImageComboAdres,
            this.repositoryItemCheckVeli});
            this.grid.Size = new System.Drawing.Size(670, 335);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colVeli,
            this.colFaturaAdresi,
            this.colYakinlikId,
            this.colYakinlikAdi,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colEvTelefon,
            this.colIsTelefon1,
            this.colCepTelefon1,
            this.colEvAdres,
            this.colEvAdresIlAdi,
            this.colEvAdresIlceAdi,
            this.colIsAdres,
            this.colIsAdresIlAdi,
            this.colIsAdresIlceAdi,
            this.colMeslekAdi,
            this.colIsyeriAdi,
            this.colGorevAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "İletişim Bilgileri";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colVeli);
            this.gridBand1.Columns.Add(this.colFaturaAdresi);
            this.gridBand1.Columns.Add(this.colYakinlikAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 245;
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli";
            this.colVeli.ColumnEdit = this.repositoryItemCheckVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.MinWidth = 25;
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = "Kişi Öğrenci Velisi ise İşaretleyiniz.";
            this.colVeli.StatusBarKisaYol = "space : ";
            this.colVeli.StatusBarKisaYolAciklama = "İşaretle";
            this.colVeli.Visible = true;
            this.colVeli.Width = 50;
            // 
            // repositoryItemCheckVeli
            // 
            this.repositoryItemCheckVeli.AutoHeight = false;
            this.repositoryItemCheckVeli.Name = "repositoryItemCheckVeli";
            // 
            // colFaturaAdresi
            // 
            this.colFaturaAdresi.Caption = "Fatura Adresi";
            this.colFaturaAdresi.ColumnEdit = this.repositoryItemImageComboAdres;
            this.colFaturaAdresi.FieldName = "FaturaAdresi";
            this.colFaturaAdresi.MinWidth = 25;
            this.colFaturaAdresi.Name = "colFaturaAdresi";
            this.colFaturaAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFaturaAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colFaturaAdresi.OptionsFilter.AllowFilter = false;
            this.colFaturaAdresi.StatusBarAciklama = "Adres Türü Seçiniz.";
            this.colFaturaAdresi.StatusBarKisaYol = "Seçim Yap : ";
            this.colFaturaAdresi.StatusBarKisaYolAciklama = "F4";
            this.colFaturaAdresi.Visible = true;
            this.colFaturaAdresi.Width = 95;
            // 
            // repositoryItemImageComboAdres
            // 
            this.repositoryItemImageComboAdres.AutoHeight = false;
            this.repositoryItemImageComboAdres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboAdres.Name = "repositoryItemImageComboAdres";
            // 
            // colYakinlikAdi
            // 
            this.colYakinlikAdi.Caption = "Yakınlık";
            this.colYakinlikAdi.ColumnEdit = this.repositoryItemButtonYakinlik;
            this.colYakinlikAdi.FieldName = "YakinlikAdi";
            this.colYakinlikAdi.MinWidth = 25;
            this.colYakinlikAdi.Name = "colYakinlikAdi";
            this.colYakinlikAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikAdi.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikAdi.OptionsFilter.AllowFilter = false;
            this.colYakinlikAdi.StatusBarAciklama = "Yakinlik Türü Seçiniz.";
            this.colYakinlikAdi.StatusBarKisaYol = "Seçim Yap : ";
            this.colYakinlikAdi.StatusBarKisaYolAciklama = "F4";
            this.colYakinlikAdi.Visible = true;
            this.colYakinlikAdi.Width = 100;
            // 
            // repositoryItemButtonYakinlik
            // 
            this.repositoryItemButtonYakinlik.AutoHeight = false;
            this.repositoryItemButtonYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonYakinlik.Name = "repositoryItemButtonYakinlik";
            this.repositoryItemButtonYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colTcKimlikNo);
            this.gridBand2.Columns.Add(this.colAdi);
            this.gridBand2.Columns.Add(this.colSoyadi);
            this.gridBand2.Columns.Add(this.colMeslekAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 440;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.MinWidth = 25;
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTcKimlikNo.OptionsFilter.AllowAutoFilter = false;
            this.colTcKimlikNo.OptionsFilter.AllowFilter = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 120;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 120;
            // 
            // colMeslekAdi
            // 
            this.colMeslekAdi.Caption = "Meslek";
            this.colMeslekAdi.FieldName = "MeslekAdi";
            this.colMeslekAdi.MinWidth = 25;
            this.colMeslekAdi.Name = "colMeslekAdi";
            this.colMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colMeslekAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeslekAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMeslekAdi.OptionsFilter.AllowFilter = false;
            this.colMeslekAdi.StatusBarAciklama = null;
            this.colMeslekAdi.StatusBarKisaYol = null;
            this.colMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colMeslekAdi.Visible = true;
            this.colMeslekAdi.Width = 100;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon";
            this.gridBand3.Columns.Add(this.colEvTelefon);
            this.gridBand3.Columns.Add(this.colCepTelefon1);
            this.gridBand3.Columns.Add(this.colIsTelefon1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
            // 
            // colEvTelefon
            // 
            this.colEvTelefon.Caption = "Ev Tel";
            this.colEvTelefon.FieldName = "EvTelefon";
            this.colEvTelefon.MinWidth = 25;
            this.colEvTelefon.Name = "colEvTelefon";
            this.colEvTelefon.OptionsColumn.AllowEdit = false;
            this.colEvTelefon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvTelefon.OptionsFilter.AllowAutoFilter = false;
            this.colEvTelefon.OptionsFilter.AllowFilter = false;
            this.colEvTelefon.StatusBarAciklama = null;
            this.colEvTelefon.StatusBarKisaYol = null;
            this.colEvTelefon.StatusBarKisaYolAciklama = null;
            this.colEvTelefon.Visible = true;
            this.colEvTelefon.Width = 100;
            // 
            // colCepTelefon1
            // 
            this.colCepTelefon1.Caption = "Cep Tel";
            this.colCepTelefon1.FieldName = "CepTelefon1";
            this.colCepTelefon1.MinWidth = 25;
            this.colCepTelefon1.Name = "colCepTelefon1";
            this.colCepTelefon1.OptionsColumn.AllowEdit = false;
            this.colCepTelefon1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCepTelefon1.OptionsFilter.AllowAutoFilter = false;
            this.colCepTelefon1.OptionsFilter.AllowFilter = false;
            this.colCepTelefon1.StatusBarAciklama = null;
            this.colCepTelefon1.StatusBarKisaYol = null;
            this.colCepTelefon1.StatusBarKisaYolAciklama = null;
            this.colCepTelefon1.Visible = true;
            this.colCepTelefon1.Width = 100;
            // 
            // colIsTelefon1
            // 
            this.colIsTelefon1.Caption = "İş Tel";
            this.colIsTelefon1.FieldName = "IsTelefon1";
            this.colIsTelefon1.MinWidth = 25;
            this.colIsTelefon1.Name = "colIsTelefon1";
            this.colIsTelefon1.OptionsColumn.AllowEdit = false;
            this.colIsTelefon1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsTelefon1.OptionsFilter.AllowAutoFilter = false;
            this.colIsTelefon1.OptionsFilter.AllowFilter = false;
            this.colIsTelefon1.StatusBarAciklama = null;
            this.colIsTelefon1.StatusBarKisaYol = null;
            this.colIsTelefon1.StatusBarKisaYolAciklama = null;
            this.colIsTelefon1.Visible = true;
            this.colIsTelefon1.Width = 100;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ev Adresi";
            this.gridBand4.Columns.Add(this.colEvAdres);
            this.gridBand4.Columns.Add(this.colEvAdresIlAdi);
            this.gridBand4.Columns.Add(this.colEvAdresIlceAdi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 350;
            // 
            // colEvAdres
            // 
            this.colEvAdres.Caption = "Ev Adresi";
            this.colEvAdres.FieldName = "EvAdres";
            this.colEvAdres.MinWidth = 25;
            this.colEvAdres.Name = "colEvAdres";
            this.colEvAdres.OptionsColumn.AllowEdit = false;
            this.colEvAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdres.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdres.OptionsFilter.AllowFilter = false;
            this.colEvAdres.StatusBarAciklama = null;
            this.colEvAdres.StatusBarKisaYol = null;
            this.colEvAdres.StatusBarKisaYolAciklama = null;
            this.colEvAdres.Visible = true;
            this.colEvAdres.Width = 150;
            // 
            // colEvAdresIlAdi
            // 
            this.colEvAdresIlAdi.Caption = "İl";
            this.colEvAdresIlAdi.CustomizationCaption = "Ev Adres İl";
            this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
            this.colEvAdresIlAdi.MinWidth = 25;
            this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
            this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlAdi.StatusBarAciklama = null;
            this.colEvAdresIlAdi.StatusBarKisaYol = null;
            this.colEvAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlAdi.Visible = true;
            this.colEvAdresIlAdi.Width = 100;
            // 
            // colEvAdresIlceAdi
            // 
            this.colEvAdresIlceAdi.Caption = "İlçe";
            this.colEvAdresIlceAdi.CustomizationCaption = "Ev Adres İlçe";
            this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
            this.colEvAdresIlceAdi.MinWidth = 25;
            this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
            this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresIlceAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresIlceAdi.StatusBarAciklama = null;
            this.colEvAdresIlceAdi.StatusBarKisaYol = null;
            this.colEvAdresIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresIlceAdi.Visible = true;
            this.colEvAdresIlceAdi.Width = 100;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "İş Adresi";
            this.gridBand5.Columns.Add(this.colIsAdres);
            this.gridBand5.Columns.Add(this.colIsAdresIlAdi);
            this.gridBand5.Columns.Add(this.colIsAdresIlceAdi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 350;
            // 
            // colIsAdres
            // 
            this.colIsAdres.Caption = "İş Adresi";
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.MinWidth = 25;
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.OptionsColumn.AllowEdit = false;
            this.colIsAdres.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdres.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdres.OptionsFilter.AllowFilter = false;
            this.colIsAdres.StatusBarAciklama = null;
            this.colIsAdres.StatusBarKisaYol = null;
            this.colIsAdres.StatusBarKisaYolAciklama = null;
            this.colIsAdres.Visible = true;
            this.colIsAdres.Width = 150;
            // 
            // colIsAdresIlAdi
            // 
            this.colIsAdresIlAdi.Caption = "İl";
            this.colIsAdresIlAdi.CustomizationCaption = "İş Adres İl";
            this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
            this.colIsAdresIlAdi.MinWidth = 25;
            this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
            this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresIlAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresIlAdi.StatusBarAciklama = null;
            this.colIsAdresIlAdi.StatusBarKisaYol = null;
            this.colIsAdresIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresIlAdi.Visible = true;
            this.colIsAdresIlAdi.Width = 100;
            // 
            // colIsAdresIlceAdi
            // 
            this.colIsAdresIlceAdi.Caption = "İlçe";
            this.colIsAdresIlceAdi.CustomizationCaption = "İş Adres İlçe";
            this.colIsAdresIlceAdi.FieldName = "IsAdresIlceAdi";
            this.colIsAdresIlceAdi.MinWidth = 25;
            this.colIsAdresIlceAdi.Name = "colIsAdresIlceAdi";
            this.colIsAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresIlceAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresIlceAdi.StatusBarAciklama = null;
            this.colIsAdresIlceAdi.StatusBarKisaYol = null;
            this.colIsAdresIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresIlceAdi.Visible = true;
            this.colIsAdresIlceAdi.Width = 100;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Çalıştığı veya Sahibi Olduğu İş yeri Bilgisi";
            this.gridBand6.Columns.Add(this.colIsyeriAdi);
            this.gridBand6.Columns.Add(this.colGorevAdi);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 375;
            // 
            // colIsyeriAdi
            // 
            this.colIsyeriAdi.Caption = "İşyeri Adı";
            this.colIsyeriAdi.FieldName = "IsyeriAdi";
            this.colIsyeriAdi.MinWidth = 25;
            this.colIsyeriAdi.Name = "colIsyeriAdi";
            this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsyeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsyeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsyeriAdi.OptionsFilter.AllowFilter = false;
            this.colIsyeriAdi.StatusBarAciklama = null;
            this.colIsyeriAdi.StatusBarKisaYol = null;
            this.colIsyeriAdi.StatusBarKisaYolAciklama = null;
            this.colIsyeriAdi.Visible = true;
            this.colIsyeriAdi.Width = 250;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görev";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.MinWidth = 25;
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorevAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGorevAdi.OptionsFilter.AllowFilter = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisaYol = null;
            this.colGorevAdi.StatusBarKisaYolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.Width = 125;
            // 
            // colYakinlikId
            // 
            this.colYakinlikId.Caption = "YakinlikId";
            this.colYakinlikId.FieldName = "YakinlikId";
            this.colYakinlikId.MinWidth = 25;
            this.colYakinlikId.Name = "colYakinlikId";
            this.colYakinlikId.OptionsColumn.AllowEdit = false;
            this.colYakinlikId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikId.OptionsColumn.ShowInCustomizationForm = false;
            this.colYakinlikId.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikId.OptionsFilter.AllowFilter = false;
            this.colYakinlikId.StatusBarAciklama = null;
            this.colYakinlikId.StatusBarKisaYol = null;
            this.colYakinlikId.StatusBarKisaYolAciklama = null;
            this.colYakinlikId.Width = 94;
            // 
            // IletisimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IletisimBilgileriTable";
            this.Size = new System.Drawing.Size(670, 359);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckVeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonYakinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyBandedGridControl grid;
        private Grids.MyBandedGridView tablo;
        private Grids.MyBandedGridColumn colVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckVeli;
        private Grids.MyBandedGridColumn colFaturaAdresi;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboAdres;
        private Grids.MyBandedGridColumn colYakinlikAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonYakinlik;
        private Grids.MyBandedGridColumn colTcKimlikNo;
        private Grids.MyBandedGridColumn colAdi;
        private Grids.MyBandedGridColumn colSoyadi;
        private Grids.MyBandedGridColumn colMeslekAdi;
        private Grids.MyBandedGridColumn colEvTelefon;
        private Grids.MyBandedGridColumn colCepTelefon1;
        private Grids.MyBandedGridColumn colIsTelefon1;
        private Grids.MyBandedGridColumn colEvAdres;
        private Grids.MyBandedGridColumn colEvAdresIlAdi;
        private Grids.MyBandedGridColumn colEvAdresIlceAdi;
        private Grids.MyBandedGridColumn colIsAdres;
        private Grids.MyBandedGridColumn colIsAdresIlAdi;
        private Grids.MyBandedGridColumn colIsAdresIlceAdi;
        private Grids.MyBandedGridColumn colIsyeriAdi;
        private Grids.MyBandedGridColumn colGorevAdi;
        private Grids.MyBandedGridColumn colYakinlikId;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}
