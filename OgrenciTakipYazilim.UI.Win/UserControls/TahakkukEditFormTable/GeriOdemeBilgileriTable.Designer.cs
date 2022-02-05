namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class GeriOdemeBilgileriTable
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
            this.colTarih = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colHesapTuru = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemImageComboHesapTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colHesapId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHesapAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemButtonHesap = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTutar = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTutar = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboHesapTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemButtonHesap,
            this.repositoryItemTutar,
            this.repositoryItemImageComboHesapTuru});
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
            this.colTarih,
            this.colHesapTuru,
            this.colHesapId,
            this.colHesapAdi,
            this.colTutar,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsCustomization.AllowColumnMoving = false;
            this.tablo.OptionsCustomization.AllowSort = false;
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
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Geri Ödeme Bilgileri Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Hareket Ekle";
            this.tablo.ViewCaption = "Geri Ödeme Bilgileri";
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsFilter.AllowAutoFilter = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.StatusBarAciklama = "Tarih Seçiniz.";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 120;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemTarih.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.ColumnEdit = this.repositoryItemImageComboHesapTuru;
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.MinWidth = 25;
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsFilter.AllowAutoFilter = false;
            this.colHesapTuru.OptionsFilter.AllowFilter = false;
            this.colHesapTuru.StatusBarAciklama = "Hesap Türü Seçiniz.";
            this.colHesapTuru.StatusBarKisaYol = "F4 : ";
            this.colHesapTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.VisibleIndex = 1;
            this.colHesapTuru.Width = 150;
            // 
            // repositoryItemImageComboHesapTuru
            // 
            this.repositoryItemImageComboHesapTuru.AutoHeight = false;
            this.repositoryItemImageComboHesapTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboHesapTuru.Name = "repositoryItemImageComboHesapTuru";
            // 
            // colHesapId
            // 
            this.colHesapId.Caption = "HesapId";
            this.colHesapId.FieldName = "HesapId";
            this.colHesapId.MinWidth = 25;
            this.colHesapId.Name = "colHesapId";
            this.colHesapId.OptionsColumn.AllowEdit = false;
            this.colHesapId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHesapId.OptionsFilter.AllowAutoFilter = false;
            this.colHesapId.OptionsFilter.AllowFilter = false;
            this.colHesapId.StatusBarAciklama = null;
            this.colHesapId.StatusBarKisaYol = null;
            this.colHesapId.StatusBarKisaYolAciklama = null;
            this.colHesapId.Width = 90;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.ColumnEdit = this.repositoryItemButtonHesap;
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.MinWidth = 25;
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHesapAdi.OptionsFilter.AllowFilter = false;
            this.colHesapAdi.StatusBarAciklama = "Hesap Seçiniz.";
            this.colHesapAdi.StatusBarKisaYol = "F4 : ";
            this.colHesapAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 2;
            this.colHesapAdi.Width = 200;
            // 
            // repositoryItemButtonHesap
            // 
            this.repositoryItemButtonHesap.AutoHeight = false;
            this.repositoryItemButtonHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonHesap.Name = "repositoryItemButtonHesap";
            this.repositoryItemButtonHesap.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryItemTutar;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsFilter.AllowAutoFilter = false;
            this.colTutar.OptionsFilter.AllowFilter = false;
            this.colTutar.StatusBarAciklama = "Tutar Giriniz.";
            this.colTutar.StatusBarKisaYol = "F4 : ";
            this.colTutar.StatusBarKisaYolAciklama = "Hesap Makinası";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 100;
            // 
            // repositoryItemTutar
            // 
            this.repositoryItemTutar.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTutar.AutoHeight = false;
            this.repositoryItemTutar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTutar.DisplayFormat.FormatString = "n2";
            this.repositoryItemTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTutar.EditFormat.FormatString = "n2";
            this.repositoryItemTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTutar.MaskSettings.Set("mask", "n2");
            this.repositoryItemTutar.Name = "repositoryItemTutar";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 200;
            // 
            // GeriOdemeBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "GeriOdemeBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboHesapTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyGridColumn colHesapTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboHesapTuru;
        private Grids.MyGridColumn colHesapId;
        private Grids.MyGridColumn colHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonHesap;
        private Grids.MyGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemTutar;
        private Grids.MyGridColumn colAciklama;
    }
}
