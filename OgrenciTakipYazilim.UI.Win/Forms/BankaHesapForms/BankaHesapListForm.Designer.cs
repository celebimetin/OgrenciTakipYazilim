﻿namespace OgrenciTakipYazilim.UI.Win.Forms.BankaHesapForms
{
    partial class BankaHesapListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankaHesapListForm));
            this.longNavigator = new OgrenciTakipYazilim.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.tablo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHesapAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHesapTuru = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankaAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankaSubeAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColHesapAcilisTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBlokeGunSayisi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHesapNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.ColIbanNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsyeriNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTerminalNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1Adi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(1287, 128);
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
            this.longNavigator.MinimumSize = new System.Drawing.Size(700, 24);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1287, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 128);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit});
            this.grid.Size = new System.Drawing.Size(1287, 312);
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
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colHesapAdi,
            this.colHesapTuru,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.ColHesapAcilisTarihi,
            this.colBlokeGunSayisi,
            this.colHesapNo,
            this.ColIbanNo,
            this.colIsyeriNo,
            this.colTerminalNo,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colAciklama});
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
            this.tablo.ViewCaption = "Banka Hesap Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Hesap Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colHesapAdi);
            this.gridBand1.Columns.Add(this.colHesapTuru);
            this.gridBand1.Columns.Add(this.colBankaAdi);
            this.gridBand1.Columns.Add(this.colBankaSubeAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 750;
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
            this.colKod.Width = 150;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisaYol = null;
            this.colHesapAdi.StatusBarKisaYolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.Width = 150;
            // 
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsColumn.AllowEdit = false;
            this.colHesapTuru.StatusBarAciklama = null;
            this.colHesapTuru.StatusBarKisaYol = null;
            this.colHesapTuru.StatusBarKisaYolAciklama = null;
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.Width = 150;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 150;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube Adı";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Hesap Detay Bilgileri";
            this.gridBand2.Columns.Add(this.ColHesapAcilisTarihi);
            this.gridBand2.Columns.Add(this.colBlokeGunSayisi);
            this.gridBand2.Columns.Add(this.colHesapNo);
            this.gridBand2.Columns.Add(this.ColIbanNo);
            this.gridBand2.Columns.Add(this.colIsyeriNo);
            this.gridBand2.Columns.Add(this.colTerminalNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 840;
            // 
            // ColHesapAcilisTarihi
            // 
            this.ColHesapAcilisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.ColHesapAcilisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColHesapAcilisTarihi.Caption = "Açılış Tarihi";
            this.ColHesapAcilisTarihi.ColumnEdit = this.repositoryItemDateEdit;
            this.ColHesapAcilisTarihi.CustomizationCaption = "Hesap Açılış Tarihi";
            this.ColHesapAcilisTarihi.FieldName = "HesapAcilisTarihi";
            this.ColHesapAcilisTarihi.Name = "ColHesapAcilisTarihi";
            this.ColHesapAcilisTarihi.OptionsColumn.AllowEdit = false;
            this.ColHesapAcilisTarihi.StatusBarAciklama = null;
            this.ColHesapAcilisTarihi.StatusBarKisaYol = null;
            this.ColHesapAcilisTarihi.StatusBarKisaYolAciklama = null;
            this.ColHesapAcilisTarihi.Visible = true;
            this.ColHesapAcilisTarihi.Width = 120;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            // 
            // colBlokeGunSayisi
            // 
            this.colBlokeGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colBlokeGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBlokeGunSayisi.Caption = "Bloke Gün Sayısı";
            this.colBlokeGunSayisi.FieldName = "BlokeGunSayisi";
            this.colBlokeGunSayisi.Name = "colBlokeGunSayisi";
            this.colBlokeGunSayisi.OptionsColumn.AllowEdit = false;
            this.colBlokeGunSayisi.StatusBarAciklama = null;
            this.colBlokeGunSayisi.StatusBarKisaYol = null;
            this.colBlokeGunSayisi.StatusBarKisaYolAciklama = null;
            this.colBlokeGunSayisi.Visible = true;
            this.colBlokeGunSayisi.Width = 120;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 150;
            // 
            // ColIbanNo
            // 
            this.ColIbanNo.Caption = "Iban No";
            this.ColIbanNo.FieldName = "IbanNo";
            this.ColIbanNo.Name = "ColIbanNo";
            this.ColIbanNo.OptionsColumn.AllowEdit = false;
            this.ColIbanNo.StatusBarAciklama = null;
            this.ColIbanNo.StatusBarKisaYol = null;
            this.ColIbanNo.StatusBarKisaYolAciklama = null;
            this.ColIbanNo.Visible = true;
            this.ColIbanNo.Width = 150;
            // 
            // colIsyeriNo
            // 
            this.colIsyeriNo.Caption = "İşyeri No";
            this.colIsyeriNo.FieldName = "IsyeriNo";
            this.colIsyeriNo.Name = "colIsyeriNo";
            this.colIsyeriNo.OptionsColumn.AllowEdit = false;
            this.colIsyeriNo.StatusBarAciklama = null;
            this.colIsyeriNo.StatusBarKisaYol = null;
            this.colIsyeriNo.StatusBarKisaYolAciklama = null;
            this.colIsyeriNo.Visible = true;
            this.colIsyeriNo.Width = 150;
            // 
            // colTerminalNo
            // 
            this.colTerminalNo.Caption = "Terminal No";
            this.colTerminalNo.FieldName = "TerminalNo";
            this.colTerminalNo.Name = "colTerminalNo";
            this.colTerminalNo.OptionsColumn.AllowEdit = false;
            this.colTerminalNo.StatusBarAciklama = null;
            this.colTerminalNo.StatusBarKisaYol = null;
            this.colTerminalNo.StatusBarKisaYolAciklama = null;
            this.colTerminalNo.Visible = true;
            this.colTerminalNo.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colOzelKod1Adi);
            this.gridBand3.Columns.Add(this.colOzelKod2Adi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 250;
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
            this.colOzelKod1Adi.Width = 125;
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
            this.colOzelKod2Adi.Width = 125;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colAciklama);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 300;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // BankaHesapListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "BankaHesapListForm";
            this.Text = "Banka Hesap Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grids.MyBandedGridColumn colHesapAdi;
        private UserControls.Grids.MyBandedGridColumn colHesapTuru;
        private UserControls.Grids.MyBandedGridColumn colBankaAdi;
        private UserControls.Grids.MyBandedGridColumn colBankaSubeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn ColHesapAcilisTarihi;
        private UserControls.Grids.MyBandedGridColumn colBlokeGunSayisi;
        private UserControls.Grids.MyBandedGridColumn colHesapNo;
        private UserControls.Grids.MyBandedGridColumn ColIbanNo;
        private UserControls.Grids.MyBandedGridColumn colIsyeriNo;
        private UserControls.Grids.MyBandedGridColumn colTerminalNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grids.MyBandedGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
    }
}