﻿namespace OgrenciTakipYazilim.UI.Win.Forms.OgrenciForms
{
    partial class OgrenciListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListForm));
            this.longNavigator = new OgrenciTakipYazilim.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.tablo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCinsiyet = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTelefon = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBabaAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAnneAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1Adi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod3Adi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 440);
            this.longNavigator.MinimumSize = new System.Drawing.Size(612, 24);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(988, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 128);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(988, 312);
            this.grid.TabIndex = 3;
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
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colCinsiyet,
            this.colTelefon,
            this.colBabaAdi,
            this.colAnneAdi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colOzelKod3Adi});
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
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Öğrenci Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colCinsiyet);
            this.gridBand1.Columns.Add(this.colTelefon);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Columns.Add(this.colAnneAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1040;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 120;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "Tc Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 120;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 150;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 150;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.Caption = "Cinsiyet";
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.OptionsColumn.AllowEdit = false;
            this.colCinsiyet.StatusBarAciklama = null;
            this.colCinsiyet.StatusBarKisaYol = null;
            this.colCinsiyet.StatusBarKisaYolAciklama = null;
            this.colCinsiyet.Visible = true;
            this.colCinsiyet.Width = 100;
            // 
            // colTelefon
            // 
            this.colTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.StatusBarAciklama = null;
            this.colTelefon.StatusBarKisaYol = null;
            this.colTelefon.StatusBarKisaYolAciklama = null;
            this.colTelefon.Visible = true;
            this.colTelefon.Width = 100;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = null;
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 150;
            // 
            // colAnneAdi
            // 
            this.colAnneAdi.Caption = "Anne Adı";
            this.colAnneAdi.FieldName = "AnneAdi";
            this.colAnneAdi.Name = "colAnneAdi";
            this.colAnneAdi.OptionsColumn.AllowEdit = false;
            this.colAnneAdi.StatusBarAciklama = null;
            this.colAnneAdi.StatusBarKisaYol = null;
            this.colAnneAdi.StatusBarKisaYolAciklama = null;
            this.colAnneAdi.Visible = true;
            this.colAnneAdi.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod";
            this.gridBand2.Columns.Add(this.colOzelKod1Adi);
            this.gridBand2.Columns.Add(this.colOzelKod2Adi);
            this.gridBand2.Columns.Add(this.colOzelKod3Adi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 450;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.Width = 150;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.Width = 150;
            // 
            // colOzelKod3Adi
            // 
            this.colOzelKod3Adi.Caption = "Özel Kod-3";
            this.colOzelKod3Adi.FieldName = "OzelKod3Adi";
            this.colOzelKod3Adi.Name = "colOzelKod3Adi";
            this.colOzelKod3Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod3Adi.StatusBarAciklama = null;
            this.colOzelKod3Adi.StatusBarKisaYol = null;
            this.colOzelKod3Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod3Adi.Visible = true;
            this.colOzelKod3Adi.Width = 150;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // OgrenciListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "OgrenciListForm";
            this.Text = "Ögrenci Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grids.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grids.MyBandedGridColumn colAdi;
        private UserControls.Grids.MyBandedGridColumn colSoyadi;
        private UserControls.Grids.MyBandedGridColumn colCinsiyet;
        private UserControls.Grids.MyBandedGridColumn colTelefon;
        private UserControls.Grids.MyBandedGridColumn colBabaAdi;
        private UserControls.Grids.MyBandedGridColumn colAnneAdi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod3Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}