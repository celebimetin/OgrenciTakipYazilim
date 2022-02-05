namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class EposBilgileriTable
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
            this.grid = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridView();
            this.colAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSoyadi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemButtonBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEposKartTuru = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemImageComboBoxKartTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colKartNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTextKartNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSonkullanmaTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTextSonKullanmaTarhi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGuvenlikKod = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTextGuvenlikKodu = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxKartTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextKartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextSonKullanmaTarhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextGuvenlikKodu)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonBanka,
            this.repositoryItemImageComboBoxKartTuru,
            this.repositoryItemTextKartNo,
            this.repositoryItemTextSonKullanmaTarhi,
            this.repositoryItemTextGuvenlikKodu});
            this.grid.Size = new System.Drawing.Size(700, 397);
            this.grid.TabIndex = 5;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colBankaId,
            this.colBankaAdi,
            this.colEposKartTuru,
            this.colKartNo,
            this.colSonkullanmaTarihi,
            this.colGuvenlikKod});
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
            this.tablo.StatusBarAciklama = "Epos Bilgileri Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Kısayol";
            this.tablo.ViewCaption = "Epos Bilgileri";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = "Kart Sahinin Adını Giriniz.";
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 150;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = "Kart Sahinin Soyadını Giriniz.";
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 150;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.MinWidth = 25;
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowEdit = false;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisaYol = null;
            this.colBankaId.StatusBarKisaYolAciklama = null;
            this.colBankaId.Width = 95;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.ColumnEdit = this.repositoryItemButtonBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.MinWidth = 25;
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = "Banka Seçiniz.";
            this.colBankaAdi.StatusBarKisaYol = "F4 : ";
            this.colBankaAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.VisibleIndex = 2;
            this.colBankaAdi.Width = 150;
            // 
            // repositoryItemButtonBanka
            // 
            this.repositoryItemButtonBanka.AutoHeight = false;
            this.repositoryItemButtonBanka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonBanka.Name = "repositoryItemButtonBanka";
            this.repositoryItemButtonBanka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colEposKartTuru
            // 
            this.colEposKartTuru.AppearanceCell.Options.UseTextOptions = true;
            this.colEposKartTuru.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEposKartTuru.Caption = "Kart Türü";
            this.colEposKartTuru.ColumnEdit = this.repositoryItemImageComboBoxKartTuru;
            this.colEposKartTuru.FieldName = "EposKartTuru";
            this.colEposKartTuru.MinWidth = 25;
            this.colEposKartTuru.Name = "colEposKartTuru";
            this.colEposKartTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEposKartTuru.OptionsFilter.AllowAutoFilter = false;
            this.colEposKartTuru.OptionsFilter.AllowFilter = false;
            this.colEposKartTuru.StatusBarAciklama = "Kart Türü Seçiniz.";
            this.colEposKartTuru.StatusBarKisaYol = "F4 : ";
            this.colEposKartTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colEposKartTuru.Visible = true;
            this.colEposKartTuru.VisibleIndex = 3;
            this.colEposKartTuru.Width = 150;
            // 
            // repositoryItemImageComboBoxKartTuru
            // 
            this.repositoryItemImageComboBoxKartTuru.AutoHeight = false;
            this.repositoryItemImageComboBoxKartTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBoxKartTuru.Name = "repositoryItemImageComboBoxKartTuru";
            // 
            // colKartNo
            // 
            this.colKartNo.AppearanceCell.Options.UseTextOptions = true;
            this.colKartNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.ColumnEdit = this.repositoryItemTextKartNo;
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.MinWidth = 25;
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartNo.OptionsFilter.AllowAutoFilter = false;
            this.colKartNo.OptionsFilter.AllowFilter = false;
            this.colKartNo.StatusBarAciklama = "Kart No Giriniz.";
            this.colKartNo.StatusBarKisaYol = null;
            this.colKartNo.StatusBarKisaYolAciklama = null;
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 4;
            this.colKartNo.Width = 200;
            // 
            // repositoryItemTextKartNo
            // 
            this.repositoryItemTextKartNo.AutoHeight = false;
            this.repositoryItemTextKartNo.BeepOnError = false;
            this.repositoryItemTextKartNo.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.repositoryItemTextKartNo.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.repositoryItemTextKartNo.MaskSettings.Set("mask", "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?");
            this.repositoryItemTextKartNo.Name = "repositoryItemTextKartNo";
            // 
            // colSonkullanmaTarihi
            // 
            this.colSonkullanmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonkullanmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonkullanmaTarihi.Caption = "Son Kullanma Tarihi";
            this.colSonkullanmaTarihi.ColumnEdit = this.repositoryItemTextSonKullanmaTarhi;
            this.colSonkullanmaTarihi.FieldName = "SonkullanmaTarihi";
            this.colSonkullanmaTarihi.MinWidth = 25;
            this.colSonkullanmaTarihi.Name = "colSonkullanmaTarihi";
            this.colSonkullanmaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSonkullanmaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colSonkullanmaTarihi.OptionsFilter.AllowFilter = false;
            this.colSonkullanmaTarihi.StatusBarAciklama = "Son Kullanma Tarihini Giriniz.";
            this.colSonkullanmaTarihi.StatusBarKisaYol = null;
            this.colSonkullanmaTarihi.StatusBarKisaYolAciklama = null;
            this.colSonkullanmaTarihi.Visible = true;
            this.colSonkullanmaTarihi.VisibleIndex = 5;
            this.colSonkullanmaTarihi.Width = 130;
            // 
            // repositoryItemTextSonKullanmaTarhi
            // 
            this.repositoryItemTextSonKullanmaTarhi.AutoHeight = false;
            this.repositoryItemTextSonKullanmaTarhi.BeepOnError = false;
            this.repositoryItemTextSonKullanmaTarhi.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.repositoryItemTextSonKullanmaTarhi.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.repositoryItemTextSonKullanmaTarhi.MaskSettings.Set("mask", "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]");
            this.repositoryItemTextSonKullanmaTarhi.Name = "repositoryItemTextSonKullanmaTarhi";
            // 
            // colGuvenlikKod
            // 
            this.colGuvenlikKod.AppearanceCell.Options.UseTextOptions = true;
            this.colGuvenlikKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGuvenlikKod.Caption = "Güvenlik Kodu";
            this.colGuvenlikKod.ColumnEdit = this.repositoryItemTextGuvenlikKodu;
            this.colGuvenlikKod.FieldName = "GuvenlikKod";
            this.colGuvenlikKod.MinWidth = 25;
            this.colGuvenlikKod.Name = "colGuvenlikKod";
            this.colGuvenlikKod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuvenlikKod.OptionsFilter.AllowAutoFilter = false;
            this.colGuvenlikKod.OptionsFilter.AllowFilter = false;
            this.colGuvenlikKod.StatusBarAciklama = null;
            this.colGuvenlikKod.StatusBarKisaYol = null;
            this.colGuvenlikKod.StatusBarKisaYolAciklama = null;
            this.colGuvenlikKod.Visible = true;
            this.colGuvenlikKod.VisibleIndex = 6;
            this.colGuvenlikKod.Width = 94;
            // 
            // repositoryItemTextGuvenlikKodu
            // 
            this.repositoryItemTextGuvenlikKodu.AutoHeight = false;
            this.repositoryItemTextGuvenlikKodu.BeepOnError = false;
            this.repositoryItemTextGuvenlikKodu.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.repositoryItemTextGuvenlikKodu.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.repositoryItemTextGuvenlikKodu.MaskSettings.Set("mask", "\\d\\d\\d");
            this.repositoryItemTextGuvenlikKodu.Name = "repositoryItemTextGuvenlikKodu";
            // 
            // EposBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EposBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxKartTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextKartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextSonKullanmaTarhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextGuvenlikKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colAdi;
        private Grids.MyGridColumn colSoyadi;
        private Grids.MyGridColumn colBankaId;
        private Grids.MyGridColumn colBankaAdi;
        private Grids.MyGridColumn colEposKartTuru;
        private Grids.MyGridColumn colKartNo;
        private Grids.MyGridColumn colSonkullanmaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBanka;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBoxKartTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextKartNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextSonKullanmaTarhi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextGuvenlikKodu;
        private Grids.MyGridColumn colGuvenlikKod;
    }
}
