namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class IndirimBilgileriTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colIptalEdildi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.grid = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridView();
            this.colIndirimAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBurutIndirim = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenIndirim = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetIndirim = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).BeginInit();
            this.SuspendLayout();
            // 
            // colIptalEdildi
            // 
            this.colIptalEdildi.Caption = "IptalEdildi";
            this.colIptalEdildi.FieldName = "IptalEdildi";
            this.colIptalEdildi.MinWidth = 25;
            this.colIptalEdildi.Name = "colIptalEdildi";
            this.colIptalEdildi.OptionsColumn.AllowEdit = false;
            this.colIptalEdildi.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalEdildi.StatusBarAciklama = null;
            this.colIptalEdildi.StatusBarKisaYol = null;
            this.colIptalEdildi.StatusBarKisaYolAciklama = null;
            this.colIptalEdildi.Width = 95;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemIptalTarih,
            this.repositoryItemIptalNedeni,
            this.repositoryItemDecimal,
            this.repositoryItemTarih});
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
            this.colIndirimAdi,
            this.colHizmetAdi,
            this.colIslemTarihi,
            this.colIptalTarihi,
            this.colIptalEdildi,
            this.colBurutIndirim,
            this.colKistDonemDusulenIndirim,
            this.colNetIndirim,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
            this.colIptalAciklama});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIptalEdildi;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.tablo.FormatRules.Add(gridFormatRule1);
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
            this.tablo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Öğrenciye Uygulanan İndirimleri Seçiniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "İndirim Bilgileri";
            // 
            // colIndirimAdi
            // 
            this.colIndirimAdi.Caption = "İndirim Adı";
            this.colIndirimAdi.FieldName = "IndirimAdi";
            this.colIndirimAdi.MinWidth = 25;
            this.colIndirimAdi.Name = "colIndirimAdi";
            this.colIndirimAdi.OptionsColumn.AllowEdit = false;
            this.colIndirimAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIndirimAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimAdi.OptionsFilter.AllowFilter = false;
            this.colIndirimAdi.StatusBarAciklama = null;
            this.colIndirimAdi.StatusBarKisaYol = null;
            this.colIndirimAdi.StatusBarKisaYolAciklama = null;
            this.colIndirimAdi.Visible = true;
            this.colIndirimAdi.VisibleIndex = 0;
            this.colIndirimAdi.Width = 200;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "İndirimin Uygulanacağı Hizmet";
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
            this.colHizmetAdi.VisibleIndex = 1;
            this.colHizmetAdi.Width = 200;
            // 
            // colIslemTarihi
            // 
            this.colIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemTarihi.Caption = "İşlem Tarihi";
            this.colIslemTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colIslemTarihi.FieldName = "IslemTarihi";
            this.colIslemTarihi.MinWidth = 25;
            this.colIslemTarihi.Name = "colIslemTarihi";
            this.colIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIslemTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIslemTarihi.OptionsFilter.AllowFilter = false;
            this.colIslemTarihi.StatusBarAciklama = null;
            this.colIslemTarihi.StatusBarKisaYol = null;
            this.colIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colIslemTarihi.Visible = true;
            this.colIslemTarihi.VisibleIndex = 2;
            this.colIslemTarihi.Width = 100;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIptalTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIptalTarihi.Caption = "İptal Tarihi";
            this.colIptalTarihi.ColumnEdit = this.repositoryItemIptalTarih;
            this.colIptalTarihi.FieldName = "IptalTarihi";
            this.colIptalTarihi.MinWidth = 25;
            this.colIptalTarihi.Name = "colIptalTarihi";
            this.colIptalTarihi.OptionsColumn.AllowEdit = false;
            this.colIptalTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalTarihi.OptionsFilter.AllowFilter = false;
            this.colIptalTarihi.StatusBarAciklama = "Tarih Seçiniz.";
            this.colIptalTarihi.StatusBarKisaYol = "F4 : ";
            this.colIptalTarihi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalTarihi.Visible = true;
            this.colIptalTarihi.VisibleIndex = 6;
            this.colIptalTarihi.Width = 100;
            // 
            // repositoryItemIptalTarih
            // 
            this.repositoryItemIptalTarih.AutoHeight = false;
            this.repositoryItemIptalTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarih.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemIptalTarih.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemIptalTarih.Name = "repositoryItemIptalTarih";
            // 
            // colBurutIndirim
            // 
            this.colBurutIndirim.Caption = "Bürüt İndirim";
            this.colBurutIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colBurutIndirim.FieldName = "BurutIndirim";
            this.colBurutIndirim.MinWidth = 25;
            this.colBurutIndirim.Name = "colBurutIndirim";
            this.colBurutIndirim.OptionsColumn.AllowEdit = false;
            this.colBurutIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBurutIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colBurutIndirim.OptionsFilter.AllowFilter = false;
            this.colBurutIndirim.StatusBarAciklama = "Tutar Giriniz.";
            this.colBurutIndirim.StatusBarKisaYol = "F4 : ";
            this.colBurutIndirim.StatusBarKisaYolAciklama = "Hesap Makinası";
            this.colBurutIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BurutIndirim", "{0:n2}")});
            this.colBurutIndirim.Visible = true;
            this.colBurutIndirim.VisibleIndex = 3;
            this.colBurutIndirim.Width = 100;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.MaskSettings.Set("mask", "n2");
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colKistDonemDusulenIndirim
            // 
            this.colKistDonemDusulenIndirim.Caption = "Kist Dönem Düşülen İndirim";
            this.colKistDonemDusulenIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colKistDonemDusulenIndirim.FieldName = "KistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.MinWidth = 25;
            this.colKistDonemDusulenIndirim.Name = "colKistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenIndirim.StatusBarAciklama = "Tutar Giriniz.";
            this.colKistDonemDusulenIndirim.StatusBarKisaYol = "F4 : ";
            this.colKistDonemDusulenIndirim.StatusBarKisaYolAciklama = "Hesap Makinası";
            this.colKistDonemDusulenIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenIndirim", "{0:n2}")});
            this.colKistDonemDusulenIndirim.Visible = true;
            this.colKistDonemDusulenIndirim.VisibleIndex = 4;
            this.colKistDonemDusulenIndirim.Width = 100;
            // 
            // colNetIndirim
            // 
            this.colNetIndirim.Caption = "Net İnidirim";
            this.colNetIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colNetIndirim.FieldName = "NetIndirim";
            this.colNetIndirim.MinWidth = 25;
            this.colNetIndirim.Name = "colNetIndirim";
            this.colNetIndirim.OptionsColumn.AllowEdit = false;
            this.colNetIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colNetIndirim.OptionsFilter.AllowFilter = false;
            this.colNetIndirim.StatusBarAciklama = null;
            this.colNetIndirim.StatusBarKisaYol = null;
            this.colNetIndirim.StatusBarKisaYolAciklama = null;
            this.colNetIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetIndirim", "{0:n2}")});
            this.colNetIndirim.Visible = true;
            this.colNetIndirim.VisibleIndex = 5;
            this.colNetIndirim.Width = 100;
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.MinWidth = 25;
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniId.OptionsFilter.AllowFilter = false;
            this.colIptalNedeniId.StatusBarAciklama = null;
            this.colIptalNedeniId.StatusBarKisaYol = null;
            this.colIptalNedeniId.StatusBarKisaYolAciklama = null;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "İptal Nedeni Adı";
            this.colIptalNedeniAdi.ColumnEdit = this.repositoryItemIptalNedeni;
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.MinWidth = 25;
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalNedeniAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniAdi.OptionsFilter.AllowFilter = false;
            this.colIptalNedeniAdi.StatusBarAciklama = "İptal Nedeni Seçiniz.";
            this.colIptalNedeniAdi.StatusBarKisaYol = "F4 : ";
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 7;
            this.colIptalNedeniAdi.Width = 200;
            // 
            // repositoryItemIptalNedeni
            // 
            this.repositoryItemIptalNedeni.AutoHeight = false;
            this.repositoryItemIptalNedeni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemIptalNedeni.Name = "repositoryItemIptalNedeni";
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "İptal Açıklama";
            this.colIptalAciklama.FieldName = "IptalAciklama";
            this.colIptalAciklama.MinWidth = 25;
            this.colIptalAciklama.Name = "colIptalAciklama";
            this.colIptalAciklama.OptionsColumn.AllowEdit = false;
            this.colIptalAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colIptalAciklama.OptionsFilter.AllowFilter = false;
            this.colIptalAciklama.StatusBarAciklama = "İptal Açıklaması Giriniz.";
            this.colIptalAciklama.StatusBarKisaYol = null;
            this.colIptalAciklama.StatusBarKisaYolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 8;
            this.colIptalAciklama.Width = 300;
            // 
            // IndirimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IndirimBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colIndirimAdi;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colIslemTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyGridColumn colIptalTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemIptalTarih;
        private Grids.MyGridColumn colBurutIndirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grids.MyGridColumn colKistDonemDusulenIndirim;
        private Grids.MyGridColumn colNetIndirim;
        private Grids.MyGridColumn colIptalNedeniId;
        private Grids.MyGridColumn colIptalNedeniAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemIptalNedeni;
        private Grids.MyGridColumn colIptalAciklama;
        private Grids.MyGridColumn colIptalEdildi;
    }
}
