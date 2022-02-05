﻿namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class BilgiNotlariTable
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
            this.repositoryItemDateTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBilgiNotu = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemMemoBilgiNotu = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoBilgiNotu)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTarih,
            this.repositoryItemMemoBilgiNotu});
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
            this.colBilgiNotu});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Bilgi Notu Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Kısayol";
            this.tablo.ViewCaption = "Bilgi Notları";
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemDateTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.FixedWidth = true;
            this.colTarih.OptionsFilter.AllowAutoFilter = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.StatusBarAciklama = "Tarih Seçiniz.";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 150;
            // 
            // repositoryItemDateTarih
            // 
            this.repositoryItemDateTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateTarih.AutoHeight = false;
            this.repositoryItemDateTarih.BeepOnError = false;
            this.repositoryItemDateTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTarih.DisplayFormat.FormatString = "G";
            this.repositoryItemDateTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateTarih.EditFormat.FormatString = "G";
            this.repositoryItemDateTarih.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateTarih.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemDateTarih.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemDateTarih.Name = "repositoryItemDateTarih";
            // 
            // colBilgiNotu
            // 
            this.colBilgiNotu.Caption = "Bilgi Notları";
            this.colBilgiNotu.ColumnEdit = this.repositoryItemMemoBilgiNotu;
            this.colBilgiNotu.FieldName = "BilgiNotu";
            this.colBilgiNotu.MinWidth = 25;
            this.colBilgiNotu.Name = "colBilgiNotu";
            this.colBilgiNotu.OptionsFilter.AllowAutoFilter = false;
            this.colBilgiNotu.OptionsFilter.AllowFilter = false;
            this.colBilgiNotu.StatusBarAciklama = "Not Giriniz.";
            this.colBilgiNotu.StatusBarKisaYol = null;
            this.colBilgiNotu.StatusBarKisaYolAciklama = null;
            this.colBilgiNotu.Visible = true;
            this.colBilgiNotu.VisibleIndex = 1;
            this.colBilgiNotu.Width = 520;
            // 
            // repositoryItemMemoBilgiNotu
            // 
            this.repositoryItemMemoBilgiNotu.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemMemoBilgiNotu.Name = "repositoryItemMemoBilgiNotu";
            this.repositoryItemMemoBilgiNotu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            // 
            // BilgiNotlariTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "BilgiNotlariTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoBilgiNotu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateTarih;
        private Grids.MyGridColumn colBilgiNotu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoBilgiNotu;
    }
}
