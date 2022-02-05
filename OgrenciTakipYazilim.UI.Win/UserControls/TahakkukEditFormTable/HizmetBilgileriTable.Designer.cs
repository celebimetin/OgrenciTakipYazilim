namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class HizmetBilgileriTable
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
            this.colHizmetId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServisId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServisYeriAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBaslamaTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBurutUcret = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCalcDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenUcret = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetUcret = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEgitimDonemiGunSayisi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAlinanHizmetGunSayisi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGunlukUcret = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalNedeniId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colGittigiOkulId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGittigiOkulAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemGittigiOkul = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGittigiOkul)).BeginInit();
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
            this.colIptalEdildi.Width = 94;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemCalcDecimal,
            this.repositoryItemIptalNedeni,
            this.repositoryItemGittigiOkul,
            this.repositoryItemIptalTarihi});
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
            this.colHizmetId,
            this.colHizmetAdi,
            this.colHizmetTuruId,
            this.colServisId,
            this.colServisYeriAdi,
            this.colIslemTarihi,
            this.colBaslamaTarihi,
            this.colBurutUcret,
            this.colKistDonemDusulenUcret,
            this.colNetUcret,
            this.colEgitimDonemiGunSayisi,
            this.colAlinanHizmetGunSayisi,
            this.colGunlukUcret,
            this.colIptalTarihi,
            this.colIptalEdildi,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
            this.colGittigiOkulId,
            this.colGittigiOkulAdi,
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
            this.tablo.OptionsCustomization.AllowColumnMoving = false;
            this.tablo.OptionsCustomization.AllowFilter = false;
            this.tablo.OptionsCustomization.AllowSort = false;
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
            this.tablo.StatusBarAciklama = "Öğrenciye Verilen Hizmetleri Seçiniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "Hizmet Bilgileri";
            // 
            // colHizmetId
            // 
            this.colHizmetId.Caption = "HizmetId";
            this.colHizmetId.FieldName = "HizmetId";
            this.colHizmetId.MinWidth = 25;
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.OptionsColumn.AllowEdit = false;
            this.colHizmetId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetId.StatusBarAciklama = null;
            this.colHizmetId.StatusBarKisaYol = null;
            this.colHizmetId.StatusBarKisaYolAciklama = null;
            this.colHizmetId.Width = 94;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.MinWidth = 25;
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.OptionsColumn.AllowMove = false;
            this.colHizmetAdi.OptionsColumn.AllowShowHide = false;
            this.colHizmetAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHizmetAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHizmetAdi.OptionsFilter.AllowFilter = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
            this.colHizmetAdi.Width = 250;
            // 
            // colHizmetTuruId
            // 
            this.colHizmetTuruId.Caption = "HizmetTuruId";
            this.colHizmetTuruId.FieldName = "HizmetTuruId";
            this.colHizmetTuruId.MinWidth = 25;
            this.colHizmetTuruId.Name = "colHizmetTuruId";
            this.colHizmetTuruId.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetTuruId.StatusBarAciklama = null;
            this.colHizmetTuruId.StatusBarKisaYol = null;
            this.colHizmetTuruId.StatusBarKisaYolAciklama = null;
            this.colHizmetTuruId.Width = 94;
            // 
            // colServisId
            // 
            this.colServisId.Caption = "ServisId";
            this.colServisId.FieldName = "ServisId";
            this.colServisId.MinWidth = 25;
            this.colServisId.Name = "colServisId";
            this.colServisId.OptionsColumn.AllowEdit = false;
            this.colServisId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServisId.StatusBarAciklama = null;
            this.colServisId.StatusBarKisaYol = null;
            this.colServisId.StatusBarKisaYolAciklama = null;
            this.colServisId.Width = 94;
            // 
            // colServisYeriAdi
            // 
            this.colServisYeriAdi.Caption = "Servis Yeri Adı";
            this.colServisYeriAdi.FieldName = "ServisYeriAdi";
            this.colServisYeriAdi.MinWidth = 25;
            this.colServisYeriAdi.Name = "colServisYeriAdi";
            this.colServisYeriAdi.OptionsColumn.AllowEdit = false;
            this.colServisYeriAdi.OptionsColumn.AllowMove = false;
            this.colServisYeriAdi.OptionsColumn.AllowShowHide = false;
            this.colServisYeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServisYeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colServisYeriAdi.OptionsFilter.AllowFilter = false;
            this.colServisYeriAdi.StatusBarAciklama = null;
            this.colServisYeriAdi.StatusBarKisaYol = null;
            this.colServisYeriAdi.StatusBarKisaYolAciklama = null;
            this.colServisYeriAdi.Width = 120;
            // 
            // colIslemTarihi
            // 
            this.colIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemTarihi.Caption = "Islem Tarihi";
            this.colIslemTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colIslemTarihi.FieldName = "IslemTarihi";
            this.colIslemTarihi.MinWidth = 25;
            this.colIslemTarihi.Name = "colIslemTarihi";
            this.colIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTarihi.OptionsColumn.AllowMove = false;
            this.colIslemTarihi.OptionsColumn.AllowShowHide = false;
            this.colIslemTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIslemTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIslemTarihi.OptionsFilter.AllowFilter = false;
            this.colIslemTarihi.StatusBarAciklama = null;
            this.colIslemTarihi.StatusBarKisaYol = null;
            this.colIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colIslemTarihi.Visible = true;
            this.colIslemTarihi.VisibleIndex = 5;
            this.colIslemTarihi.Width = 100;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.BeepOnError = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTarih.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Baslama Tarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.MinWidth = 25;
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.OptionsColumn.AllowMove = false;
            this.colBaslamaTarihi.OptionsColumn.AllowShowHide = false;
            this.colBaslamaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBaslamaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colBaslamaTarihi.OptionsFilter.AllowFilter = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisaYol = null;
            this.colBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 4;
            this.colBaslamaTarihi.Width = 100;
            // 
            // colBurutUcret
            // 
            this.colBurutUcret.Caption = "Bürüt Ücret";
            this.colBurutUcret.ColumnEdit = this.repositoryItemCalcDecimal;
            this.colBurutUcret.FieldName = "BurutUcret";
            this.colBurutUcret.MinWidth = 25;
            this.colBurutUcret.Name = "colBurutUcret";
            this.colBurutUcret.OptionsColumn.AllowEdit = false;
            this.colBurutUcret.OptionsColumn.AllowMove = false;
            this.colBurutUcret.OptionsColumn.AllowShowHide = false;
            this.colBurutUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBurutUcret.OptionsFilter.AllowAutoFilter = false;
            this.colBurutUcret.OptionsFilter.AllowFilter = false;
            this.colBurutUcret.StatusBarAciklama = null;
            this.colBurutUcret.StatusBarKisaYol = null;
            this.colBurutUcret.StatusBarKisaYolAciklama = null;
            this.colBurutUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BurutUcret", "{0:n2}")});
            this.colBurutUcret.Visible = true;
            this.colBurutUcret.VisibleIndex = 1;
            this.colBurutUcret.Width = 100;
            // 
            // repositoryItemCalcDecimal
            // 
            this.repositoryItemCalcDecimal.AutoHeight = false;
            this.repositoryItemCalcDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemCalcDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemCalcDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcDecimal.MaskSettings.Set("mask", "n2");
            this.repositoryItemCalcDecimal.Name = "repositoryItemCalcDecimal";
            // 
            // colKistDonemDusulenUcret
            // 
            this.colKistDonemDusulenUcret.Caption = "Kist Dönem Düşülen Ücret";
            this.colKistDonemDusulenUcret.ColumnEdit = this.repositoryItemCalcDecimal;
            this.colKistDonemDusulenUcret.FieldName = "KistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.MinWidth = 25;
            this.colKistDonemDusulenUcret.Name = "colKistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenUcret.StatusBarAciklama = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYol = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYolAciklama = null;
            this.colKistDonemDusulenUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenUcret", "{0:n2}")});
            this.colKistDonemDusulenUcret.Visible = true;
            this.colKistDonemDusulenUcret.VisibleIndex = 2;
            this.colKistDonemDusulenUcret.Width = 100;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
            this.colNetUcret.ColumnEdit = this.repositoryItemCalcDecimal;
            this.colNetUcret.FieldName = "NetUcret";
            this.colNetUcret.MinWidth = 25;
            this.colNetUcret.Name = "colNetUcret";
            this.colNetUcret.OptionsColumn.AllowEdit = false;
            this.colNetUcret.OptionsColumn.AllowMove = false;
            this.colNetUcret.OptionsColumn.AllowShowHide = false;
            this.colNetUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetUcret.OptionsFilter.AllowAutoFilter = false;
            this.colNetUcret.OptionsFilter.AllowFilter = false;
            this.colNetUcret.StatusBarAciklama = null;
            this.colNetUcret.StatusBarKisaYol = null;
            this.colNetUcret.StatusBarKisaYolAciklama = null;
            this.colNetUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetUcret", "{0:n2}")});
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 3;
            this.colNetUcret.Width = 100;
            // 
            // colEgitimDonemiGunSayisi
            // 
            this.colEgitimDonemiGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colEgitimDonemiGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimDonemiGunSayisi.Caption = "Eğitim Dönemi Gün Sayısı";
            this.colEgitimDonemiGunSayisi.FieldName = "EgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.MinWidth = 25;
            this.colEgitimDonemiGunSayisi.Name = "colEgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowEdit = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowMove = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowFilter = false;
            this.colEgitimDonemiGunSayisi.StatusBarAciklama = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYol = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYolAciklama = null;
            this.colEgitimDonemiGunSayisi.Visible = true;
            this.colEgitimDonemiGunSayisi.VisibleIndex = 6;
            this.colEgitimDonemiGunSayisi.Width = 100;
            // 
            // colAlinanHizmetGunSayisi
            // 
            this.colAlinanHizmetGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colAlinanHizmetGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlinanHizmetGunSayisi.Caption = "Alınan Hizmet Gün Sayisi";
            this.colAlinanHizmetGunSayisi.FieldName = "AlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.MinWidth = 25;
            this.colAlinanHizmetGunSayisi.Name = "colAlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowEdit = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowMove = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowFilter = false;
            this.colAlinanHizmetGunSayisi.StatusBarAciklama = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYol = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYolAciklama = null;
            this.colAlinanHizmetGunSayisi.Visible = true;
            this.colAlinanHizmetGunSayisi.VisibleIndex = 7;
            this.colAlinanHizmetGunSayisi.Width = 90;
            // 
            // colGunlukUcret
            // 
            this.colGunlukUcret.Caption = "Günlük Ücret";
            this.colGunlukUcret.ColumnEdit = this.repositoryItemCalcDecimal;
            this.colGunlukUcret.FieldName = "GunlukUcret";
            this.colGunlukUcret.MinWidth = 25;
            this.colGunlukUcret.Name = "colGunlukUcret";
            this.colGunlukUcret.OptionsColumn.AllowEdit = false;
            this.colGunlukUcret.OptionsColumn.AllowMove = false;
            this.colGunlukUcret.OptionsColumn.AllowShowHide = false;
            this.colGunlukUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGunlukUcret.OptionsFilter.AllowAutoFilter = false;
            this.colGunlukUcret.OptionsFilter.AllowFilter = false;
            this.colGunlukUcret.StatusBarAciklama = null;
            this.colGunlukUcret.StatusBarKisaYol = null;
            this.colGunlukUcret.StatusBarKisaYolAciklama = null;
            this.colGunlukUcret.Visible = true;
            this.colGunlukUcret.VisibleIndex = 8;
            this.colGunlukUcret.Width = 100;
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIptalTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIptalTarihi.Caption = "Iptal Tarihi";
            this.colIptalTarihi.ColumnEdit = this.repositoryItemIptalTarihi;
            this.colIptalTarihi.FieldName = "IptalTarihi";
            this.colIptalTarihi.MinWidth = 25;
            this.colIptalTarihi.Name = "colIptalTarihi";
            this.colIptalTarihi.OptionsColumn.AllowEdit = false;
            this.colIptalTarihi.OptionsColumn.AllowMove = false;
            this.colIptalTarihi.OptionsColumn.AllowShowHide = false;
            this.colIptalTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalTarihi.OptionsFilter.AllowFilter = false;
            this.colIptalTarihi.StatusBarAciklama = "Tarih Seçiniz.";
            this.colIptalTarihi.StatusBarKisaYol = "F4 : ";
            this.colIptalTarihi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalTarihi.Visible = true;
            this.colIptalTarihi.VisibleIndex = 9;
            this.colIptalTarihi.Width = 100;
            // 
            // repositoryItemIptalTarihi
            // 
            this.repositoryItemIptalTarihi.AutoHeight = false;
            this.repositoryItemIptalTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarihi.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemIptalTarihi.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemIptalTarihi.Name = "repositoryItemIptalTarihi";
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.MinWidth = 25;
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.StatusBarAciklama = null;
            this.colIptalNedeniId.StatusBarKisaYol = null;
            this.colIptalNedeniId.StatusBarKisaYolAciklama = null;
            this.colIptalNedeniId.Width = 94;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "Iptal Nedeni Adı";
            this.colIptalNedeniAdi.ColumnEdit = this.repositoryItemIptalNedeni;
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.MinWidth = 25;
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowMove = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowShowHide = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalNedeniAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniAdi.OptionsFilter.AllowFilter = false;
            this.colIptalNedeniAdi.StatusBarAciklama = "İptal Nedeni Seçiniz.";
            this.colIptalNedeniAdi.StatusBarKisaYol = "F4 : ";
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 10;
            this.colIptalNedeniAdi.Width = 150;
            // 
            // repositoryItemIptalNedeni
            // 
            this.repositoryItemIptalNedeni.AutoHeight = false;
            this.repositoryItemIptalNedeni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemIptalNedeni.Name = "repositoryItemIptalNedeni";
            this.repositoryItemIptalNedeni.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colGittigiOkulId
            // 
            this.colGittigiOkulId.Caption = "GittigiOkulId";
            this.colGittigiOkulId.FieldName = "GittigiOkulId";
            this.colGittigiOkulId.MinWidth = 25;
            this.colGittigiOkulId.Name = "colGittigiOkulId";
            this.colGittigiOkulId.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulId.OptionsColumn.ShowInCustomizationForm = false;
            this.colGittigiOkulId.StatusBarAciklama = null;
            this.colGittigiOkulId.StatusBarKisaYol = null;
            this.colGittigiOkulId.StatusBarKisaYolAciklama = null;
            this.colGittigiOkulId.Width = 94;
            // 
            // colGittigiOkulAdi
            // 
            this.colGittigiOkulAdi.Caption = "Gittiği Okul Adı";
            this.colGittigiOkulAdi.ColumnEdit = this.repositoryItemGittigiOkul;
            this.colGittigiOkulAdi.FieldName = "GittigiOkulAdi";
            this.colGittigiOkulAdi.MinWidth = 25;
            this.colGittigiOkulAdi.Name = "colGittigiOkulAdi";
            this.colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowMove = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowShowHide = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGittigiOkulAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGittigiOkulAdi.OptionsFilter.AllowFilter = false;
            this.colGittigiOkulAdi.StatusBarAciklama = "Okul Seçiniz";
            this.colGittigiOkulAdi.StatusBarKisaYol = "F4 : ";
            this.colGittigiOkulAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colGittigiOkulAdi.Visible = true;
            this.colGittigiOkulAdi.VisibleIndex = 11;
            this.colGittigiOkulAdi.Width = 200;
            // 
            // repositoryItemGittigiOkul
            // 
            this.repositoryItemGittigiOkul.AutoHeight = false;
            this.repositoryItemGittigiOkul.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemGittigiOkul.Name = "repositoryItemGittigiOkul";
            this.repositoryItemGittigiOkul.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "Iptal Açıklama";
            this.colIptalAciklama.FieldName = "IptalAciklama";
            this.colIptalAciklama.MinWidth = 25;
            this.colIptalAciklama.Name = "colIptalAciklama";
            this.colIptalAciklama.OptionsColumn.AllowEdit = false;
            this.colIptalAciklama.OptionsColumn.AllowMove = false;
            this.colIptalAciklama.OptionsColumn.AllowShowHide = false;
            this.colIptalAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colIptalAciklama.OptionsFilter.AllowFilter = false;
            this.colIptalAciklama.StatusBarAciklama = "İptal Açıklama Giriniz.";
            this.colIptalAciklama.StatusBarKisaYol = null;
            this.colIptalAciklama.StatusBarKisaYolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 12;
            this.colIptalAciklama.Width = 250;
            // 
            // HizmetBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "HizmetBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGittigiOkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colHizmetId;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colHizmetTuruId;
        private Grids.MyGridColumn colServisId;
        private Grids.MyGridColumn colServisYeriAdi;
        private Grids.MyGridColumn colIslemTarihi;
        private Grids.MyGridColumn colBaslamaTarihi;
        private Grids.MyGridColumn colKistDonemDusulenUcret;
        private Grids.MyGridColumn colIptalEdildi;
        private Grids.MyGridColumn colEgitimDonemiGunSayisi;
        private Grids.MyGridColumn colAlinanHizmetGunSayisi;
        private Grids.MyGridColumn colGunlukUcret;
        private Grids.MyGridColumn colIptalTarihi;
        private Grids.MyGridColumn colIptalNedeniId;
        private Grids.MyGridColumn colIptalNedeniAdi;
        private Grids.MyGridColumn colGittigiOkulId;
        private Grids.MyGridColumn colGittigiOkulAdi;
        private Grids.MyGridColumn colIptalAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemIptalNedeni;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemGittigiOkul;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemIptalTarihi;
        private Grids.MyGridColumn colNetUcret;
        private Grids.MyGridColumn colBurutUcret;
    }
}
