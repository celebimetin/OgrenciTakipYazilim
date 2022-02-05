namespace OgrenciTakipYazilim.UI.Win.UserControls.IndirimEditFormTable
{
    partial class IndirimUygulanacakHizmetTable
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
            this.colHizmetAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIndirimTutari = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.TutarCalcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIndirimOrani = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.OranSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutarCalcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OranSpinEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TutarCalcEdit,
            this.OranSpinEdit});
            this.grid.Size = new System.Drawing.Size(433, 307);
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
            this.colHizmetAdi,
            this.colIndirimTutari,
            this.colIndirimOrani});
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
            this.tablo.StatusBarAciklama = "Bu İndirim Uygulanacağı Hizmet Kartı Seçiniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Hizmet Kartı Seç";
            this.tablo.ViewCaption = "İndirimin Uygulanacağı Hizmetler";
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.MinWidth = 25;
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHizmetAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHizmetAdi.OptionsFilter.AllowFilter = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
            this.colHizmetAdi.Width = 200;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "Tutar";
            this.colIndirimTutari.ColumnEdit = this.TutarCalcEdit;
            this.colIndirimTutari.FieldName = "IndirimTutar";
            this.colIndirimTutari.MinWidth = 25;
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIndirimTutari.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimTutari.OptionsFilter.AllowFilter = false;
            this.colIndirimTutari.StatusBarAciklama = "İndirim Tutarı Giriniz.";
            this.colIndirimTutari.StatusBarKisaYol = "F4";
            this.colIndirimTutari.StatusBarKisaYolAciklama = "Hesap Makinası";
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 1;
            this.colIndirimTutari.Width = 100;
            // 
            // TutarCalcEdit
            // 
            this.TutarCalcEdit.AutoHeight = false;
            this.TutarCalcEdit.BeepOnError = false;
            this.TutarCalcEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TutarCalcEdit.DisplayFormat.FormatString = "n2";
            this.TutarCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TutarCalcEdit.EditFormat.FormatString = "n2";
            this.TutarCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TutarCalcEdit.MaskSettings.Set("mask", "c");
            this.TutarCalcEdit.Name = "TutarCalcEdit";
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.AppearanceCell.Options.UseTextOptions = true;
            this.colIndirimOrani.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndirimOrani.Caption = "Oran ( % )";
            this.colIndirimOrani.ColumnEdit = this.OranSpinEdit;
            this.colIndirimOrani.FieldName = "IndirimOran";
            this.colIndirimOrani.MinWidth = 25;
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIndirimOrani.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimOrani.OptionsFilter.AllowFilter = false;
            this.colIndirimOrani.StatusBarAciklama = null;
            this.colIndirimOrani.StatusBarKisaYol = null;
            this.colIndirimOrani.StatusBarKisaYolAciklama = "İndirim Oranı Giriniz.";
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 2;
            this.colIndirimOrani.Width = 100;
            // 
            // OranSpinEdit
            // 
            this.OranSpinEdit.AutoHeight = false;
            this.OranSpinEdit.BeepOnError = false;
            this.OranSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OranSpinEdit.DisplayFormat.FormatString = "n0";
            this.OranSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OranSpinEdit.EditFormat.FormatString = "n0";
            this.OranSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OranSpinEdit.MaskSettings.Set("mask", "P");
            this.OranSpinEdit.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.OranSpinEdit.Name = "OranSpinEdit";
            // 
            // IndirimUygulanacakHizmetTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IndirimUygulanacakHizmetTable";
            this.Size = new System.Drawing.Size(433, 331);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutarCalcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OranSpinEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colIndirimTutari;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit TutarCalcEdit;
        private Grids.MyGridColumn colIndirimOrani;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit OranSpinEdit;
    }
}
