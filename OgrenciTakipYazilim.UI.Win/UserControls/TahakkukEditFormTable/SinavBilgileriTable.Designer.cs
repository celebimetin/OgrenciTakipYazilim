namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class SinavBilgileriTable
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
            this.colSinavAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTarih = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPuanTuru = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colPuan = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSpinPuan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSira = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalcSira = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colYuzde = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSpinYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinPuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcSira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 313);
            this.insUptNavigator.Size = new System.Drawing.Size(695, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcSira,
            this.repositoryItemTarih,
            this.repositoryItemSpinPuan,
            this.repositoryItemSpinYuzde});
            this.grid.Size = new System.Drawing.Size(695, 313);
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
            this.colSinavAdi,
            this.colTarih,
            this.colPuanTuru,
            this.colPuan,
            this.colSira,
            this.colYuzde});
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
            this.tablo.StatusBarAciklama = "Sınav Bilgileri Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Kısayol";
            this.tablo.ViewCaption = "Sınav Bilgileri";
            // 
            // colSinavAdi
            // 
            this.colSinavAdi.Caption = "Sınav Adı";
            this.colSinavAdi.FieldName = "SinavAdi";
            this.colSinavAdi.MinWidth = 25;
            this.colSinavAdi.Name = "colSinavAdi";
            this.colSinavAdi.StatusBarAciklama = "Sınav Adı Giriniz.";
            this.colSinavAdi.StatusBarKisaYol = null;
            this.colSinavAdi.StatusBarKisaYolAciklama = null;
            this.colSinavAdi.Visible = true;
            this.colSinavAdi.VisibleIndex = 0;
            this.colSinavAdi.Width = 150;
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
            this.colTarih.StatusBarAciklama = "Tarih Seçiniz";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 110;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colPuanTuru
            // 
            this.colPuanTuru.Caption = "Puan Türü";
            this.colPuanTuru.FieldName = "PuanTuru";
            this.colPuanTuru.MinWidth = 25;
            this.colPuanTuru.Name = "colPuanTuru";
            this.colPuanTuru.StatusBarAciklama = "Puan Türü Giriniz.";
            this.colPuanTuru.StatusBarKisaYol = null;
            this.colPuanTuru.StatusBarKisaYolAciklama = null;
            this.colPuanTuru.Visible = true;
            this.colPuanTuru.VisibleIndex = 2;
            this.colPuanTuru.Width = 100;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "Puan";
            this.colPuan.ColumnEdit = this.repositoryItemSpinPuan;
            this.colPuan.FieldName = "Puan";
            this.colPuan.MinWidth = 25;
            this.colPuan.Name = "colPuan";
            this.colPuan.StatusBarAciklama = "Puan Giriniz.";
            this.colPuan.StatusBarKisaYol = null;
            this.colPuan.StatusBarKisaYolAciklama = null;
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 3;
            this.colPuan.Width = 100;
            // 
            // repositoryItemSpinPuan
            // 
            this.repositoryItemSpinPuan.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSpinPuan.AutoHeight = false;
            this.repositoryItemSpinPuan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinPuan.DisplayFormat.FormatString = "n5";
            this.repositoryItemSpinPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinPuan.EditFormat.FormatString = "n5";
            this.repositoryItemSpinPuan.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinPuan.MaskSettings.Set("mask", "n5");
            this.repositoryItemSpinPuan.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            327680});
            this.repositoryItemSpinPuan.Name = "repositoryItemSpinPuan";
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.ColumnEdit = this.repositoryItemCalcSira;
            this.colSira.FieldName = "Sira";
            this.colSira.MinWidth = 25;
            this.colSira.Name = "colSira";
            this.colSira.StatusBarAciklama = "Sınav Sıra No Giriniz.";
            this.colSira.StatusBarKisaYol = null;
            this.colSira.StatusBarKisaYolAciklama = null;
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 4;
            this.colSira.Width = 100;
            // 
            // repositoryItemCalcSira
            // 
            this.repositoryItemCalcSira.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemCalcSira.AutoHeight = false;
            this.repositoryItemCalcSira.BeepOnError = false;
            this.repositoryItemCalcSira.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcSira.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalcSira.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcSira.EditFormat.FormatString = "n0";
            this.repositoryItemCalcSira.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcSira.MaskSettings.Set("mask", "n0");
            this.repositoryItemCalcSira.Name = "repositoryItemCalcSira";
            // 
            // colYuzde
            // 
            this.colYuzde.Caption = "Derece ( % )";
            this.colYuzde.ColumnEdit = this.repositoryItemSpinYuzde;
            this.colYuzde.FieldName = "Yuzde";
            this.colYuzde.MinWidth = 25;
            this.colYuzde.Name = "colYuzde";
            this.colYuzde.StatusBarAciklama = "Sınav Başarı Yüzdesi Giriniz.";
            this.colYuzde.StatusBarKisaYol = null;
            this.colYuzde.StatusBarKisaYolAciklama = null;
            this.colYuzde.Visible = true;
            this.colYuzde.VisibleIndex = 5;
            this.colYuzde.Width = 100;
            // 
            // repositoryItemSpinYuzde
            // 
            this.repositoryItemSpinYuzde.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSpinYuzde.AutoHeight = false;
            this.repositoryItemSpinYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinYuzde.DisplayFormat.FormatString = "n4";
            this.repositoryItemSpinYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinYuzde.EditFormat.FormatString = "n4";
            this.repositoryItemSpinYuzde.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinYuzde.MaskSettings.Set("mask", "n4");
            this.repositoryItemSpinYuzde.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinYuzde.Name = "repositoryItemSpinYuzde";
            // 
            // SinavBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SinavBilgileriTable";
            this.Size = new System.Drawing.Size(695, 337);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinPuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcSira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colSinavAdi;
        private Grids.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyGridColumn colPuanTuru;
        private Grids.MyGridColumn colPuan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinPuan;
        private Grids.MyGridColumn colSira;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcSira;
        private Grids.MyGridColumn colYuzde;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinYuzde;
    }
}
