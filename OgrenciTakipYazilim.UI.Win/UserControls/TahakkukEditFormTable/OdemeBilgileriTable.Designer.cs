namespace OgrenciTakipYazilim.UI.Win.UserControls.TahakkukEditFormTable
{
    partial class OdemeBilgileriTable
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
            this.colPortFoyNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colOdemeTuruAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaHesapId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaHesapAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemButtonBankaHesap = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTakipNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGirisTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVade = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDateVade = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBlokeGunSayisi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTutar = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTahsil = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTahsilde = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIade = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKalan = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemButtonBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBankaSubeId = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaSubeAdi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemButtonBankaSube = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBelgeNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHesapNo = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAsilBorclu = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCiranta = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTutarYazi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colVadeYazi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBelgeDurumu = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAciklama = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSonHareketTarihi = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSonIslemYeri = new OgrenciTakipYazilim.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBankaHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateVade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateVade.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBankaSube)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateVade,
            this.repositoryItemDecimal,
            this.repositoryItemButtonBankaHesap,
            this.repositoryItemButtonBanka,
            this.repositoryItemButtonBankaSube,
            this.repositoryItemSpinEdit,
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
            this.colPortFoyNo,
            this.colOdemeTuruAdi,
            this.colBankaHesapId,
            this.colBankaHesapAdi,
            this.colTakipNo,
            this.colGirisTarihi,
            this.colVade,
            this.colBlokeGunSayisi,
            this.colTutar,
            this.colTahsil,
            this.colTahsilde,
            this.colIade,
            this.colKalan,
            this.colBankaId,
            this.colBankaAdi,
            this.colBankaSubeId,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colTutarYazi,
            this.colVadeYazi,
            this.colBelgeDurumu,
            this.colAciklama,
            this.colSonHareketTarihi,
            this.colSonIslemYeri});
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
            this.tablo.StatusBarAciklama = "Ödeme Bilgilerini Giriniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Ödeme Planı Oluştur.";
            this.tablo.ViewCaption = "Ödeme Bilgileri";
            // 
            // colPortFoyNo
            // 
            this.colPortFoyNo.Caption = "PortFöy No";
            this.colPortFoyNo.FieldName = "Id";
            this.colPortFoyNo.MinWidth = 25;
            this.colPortFoyNo.Name = "colPortFoyNo";
            this.colPortFoyNo.OptionsColumn.AllowEdit = false;
            this.colPortFoyNo.OptionsFilter.AllowAutoFilter = false;
            this.colPortFoyNo.OptionsFilter.AllowFilter = false;
            this.colPortFoyNo.StatusBarAciklama = null;
            this.colPortFoyNo.StatusBarKisaYol = null;
            this.colPortFoyNo.StatusBarKisaYolAciklama = null;
            this.colPortFoyNo.Visible = true;
            this.colPortFoyNo.VisibleIndex = 0;
            this.colPortFoyNo.Width = 100;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.MinWidth = 25;
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsFilter.AllowAutoFilter = false;
            this.colOdemeTuruAdi.OptionsFilter.AllowFilter = false;
            this.colOdemeTuruAdi.StatusBarAciklama = "Hesap Seçimi Yapınız.";
            this.colOdemeTuruAdi.StatusBarKisaYol = "F4 : ";
            this.colOdemeTuruAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 1;
            this.colOdemeTuruAdi.Width = 100;
            // 
            // colBankaHesapId
            // 
            this.colBankaHesapId.Caption = "BankaHesapId";
            this.colBankaHesapId.FieldName = "BankaHesapId";
            this.colBankaHesapId.MinWidth = 25;
            this.colBankaHesapId.Name = "colBankaHesapId";
            this.colBankaHesapId.OptionsColumn.AllowEdit = false;
            this.colBankaHesapId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaHesapId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaHesapId.OptionsFilter.AllowFilter = false;
            this.colBankaHesapId.StatusBarAciklama = null;
            this.colBankaHesapId.StatusBarKisaYol = null;
            this.colBankaHesapId.StatusBarKisaYolAciklama = null;
            this.colBankaHesapId.Width = 95;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Banka Hesap";
            this.colBankaHesapAdi.ColumnEdit = this.repositoryItemButtonBankaHesap;
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.MinWidth = 25;
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaHesapAdi.OptionsFilter.AllowFilter = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisaYol = null;
            this.colBankaHesapAdi.StatusBarKisaYolAciklama = null;
            this.colBankaHesapAdi.Width = 150;
            // 
            // repositoryItemButtonBankaHesap
            // 
            this.repositoryItemButtonBankaHesap.AutoHeight = false;
            this.repositoryItemButtonBankaHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonBankaHesap.Name = "repositoryItemButtonBankaHesap";
            this.repositoryItemButtonBankaHesap.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TakipNo";
            this.colTakipNo.MinWidth = 25;
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.OptionsColumn.AllowEdit = false;
            this.colTakipNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colTakipNo.StatusBarAciklama = "Takip No Giriniz.";
            this.colTakipNo.StatusBarKisaYol = null;
            this.colTakipNo.StatusBarKisaYolAciklama = null;
            this.colTakipNo.Width = 100;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giriş Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.MinWidth = 25;
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colGirisTarihi.OptionsFilter.AllowFilter = false;
            this.colGirisTarihi.StatusBarAciklama = "";
            this.colGirisTarihi.StatusBarKisaYol = "";
            this.colGirisTarihi.StatusBarKisaYolAciklama = "";
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.VisibleIndex = 2;
            this.colGirisTarihi.Width = 100;
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
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryItemDateVade;
            this.colVade.FieldName = "Vade";
            this.colVade.MinWidth = 25;
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.OptionsFilter.AllowAutoFilter = false;
            this.colVade.OptionsFilter.AllowFilter = false;
            this.colVade.StatusBarAciklama = "Tarih Giriniz.";
            this.colVade.StatusBarKisaYol = "F4 : ";
            this.colVade.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colVade.Visible = true;
            this.colVade.VisibleIndex = 3;
            this.colVade.Width = 100;
            // 
            // repositoryItemDateVade
            // 
            this.repositoryItemDateVade.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateVade.AutoHeight = false;
            this.repositoryItemDateVade.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateVade.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateVade.MaskSettings.Set("useAdvancingCaret", true);
            this.repositoryItemDateVade.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemDateVade.Name = "repositoryItemDateVade";
            // 
            // colBlokeGunSayisi
            // 
            this.colBlokeGunSayisi.Caption = "Bloke Gün Sayısı";
            this.colBlokeGunSayisi.ColumnEdit = this.repositoryItemSpinEdit;
            this.colBlokeGunSayisi.FieldName = "BlokeGunSayisi";
            this.colBlokeGunSayisi.MinWidth = 25;
            this.colBlokeGunSayisi.Name = "colBlokeGunSayisi";
            this.colBlokeGunSayisi.OptionsColumn.AllowEdit = false;
            this.colBlokeGunSayisi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBlokeGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colBlokeGunSayisi.OptionsFilter.AllowFilter = false;
            this.colBlokeGunSayisi.StatusBarAciklama = null;
            this.colBlokeGunSayisi.StatusBarKisaYol = null;
            this.colBlokeGunSayisi.StatusBarKisaYolAciklama = null;
            this.colBlokeGunSayisi.Width = 100;
            // 
            // repositoryItemSpinEdit
            // 
            this.repositoryItemSpinEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSpinEdit.AutoHeight = false;
            this.repositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit.MaskSettings.Set("mask", "n0");
            this.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit";
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsFilter.AllowAutoFilter = false;
            this.colTutar.OptionsFilter.AllowFilter = false;
            this.colTutar.StatusBarAciklama = "Tutar Giriniz.";
            this.colTutar.StatusBarKisaYol = "F4 : ";
            this.colTutar.StatusBarKisaYolAciklama = "Hesap Makinası";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 4;
            this.colTutar.Width = 95;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "n2";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "n2";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.MaskSettings.Set("mask", "n2");
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colTahsil
            // 
            this.colTahsil.Caption = "Tahsil";
            this.colTahsil.ColumnEdit = this.repositoryItemDecimal;
            this.colTahsil.FieldName = "Tahsil";
            this.colTahsil.MinWidth = 25;
            this.colTahsil.Name = "colTahsil";
            this.colTahsil.OptionsColumn.AllowEdit = false;
            this.colTahsil.OptionsFilter.AllowAutoFilter = false;
            this.colTahsil.OptionsFilter.AllowFilter = false;
            this.colTahsil.StatusBarAciklama = null;
            this.colTahsil.StatusBarKisaYol = null;
            this.colTahsil.StatusBarKisaYolAciklama = null;
            this.colTahsil.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tahsil", "{0:n2}")});
            this.colTahsil.Visible = true;
            this.colTahsil.VisibleIndex = 5;
            this.colTahsil.Width = 100;
            // 
            // colTahsilde
            // 
            this.colTahsilde.Caption = "Tahsilde";
            this.colTahsilde.ColumnEdit = this.repositoryItemDecimal;
            this.colTahsilde.FieldName = "Tahsilde";
            this.colTahsilde.MinWidth = 25;
            this.colTahsilde.Name = "colTahsilde";
            this.colTahsilde.OptionsColumn.AllowEdit = false;
            this.colTahsilde.OptionsFilter.AllowAutoFilter = false;
            this.colTahsilde.OptionsFilter.AllowFilter = false;
            this.colTahsilde.StatusBarAciklama = null;
            this.colTahsilde.StatusBarKisaYol = null;
            this.colTahsilde.StatusBarKisaYolAciklama = null;
            this.colTahsilde.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tahsilde", "{0:n2}")});
            this.colTahsilde.Visible = true;
            this.colTahsilde.VisibleIndex = 6;
            this.colTahsilde.Width = 100;
            // 
            // colIade
            // 
            this.colIade.Caption = "İade";
            this.colIade.ColumnEdit = this.repositoryItemDecimal;
            this.colIade.FieldName = "Iade";
            this.colIade.MinWidth = 25;
            this.colIade.Name = "colIade";
            this.colIade.OptionsColumn.AllowEdit = false;
            this.colIade.OptionsFilter.AllowAutoFilter = false;
            this.colIade.OptionsFilter.AllowFilter = false;
            this.colIade.StatusBarAciklama = null;
            this.colIade.StatusBarKisaYol = null;
            this.colIade.StatusBarKisaYolAciklama = null;
            this.colIade.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iade", "{0:n2}")});
            this.colIade.Visible = true;
            this.colIade.VisibleIndex = 7;
            this.colIade.Width = 100;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan";
            this.colKalan.ColumnEdit = this.repositoryItemDecimal;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.MinWidth = 25;
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.OptionsFilter.AllowAutoFilter = false;
            this.colKalan.OptionsFilter.AllowFilter = false;
            this.colKalan.StatusBarAciklama = null;
            this.colKalan.StatusBarKisaYol = null;
            this.colKalan.StatusBarKisaYolAciklama = null;
            this.colKalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kalan", "{0:n2}")});
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 8;
            this.colKalan.Width = 100;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.MinWidth = 25;
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowEdit = false;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaId.OptionsFilter.AllowFilter = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisaYol = null;
            this.colBankaId.StatusBarKisaYolAciklama = null;
            this.colBankaId.Width = 90;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.ColumnEdit = this.repositoryItemButtonBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.MinWidth = 25;
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = "Banka Seçiniz.";
            this.colBankaAdi.StatusBarKisaYol = "F4 : ";
            this.colBankaAdi.StatusBarKisaYolAciklama = "Seçim Yap";
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
            // colBankaSubeId
            // 
            this.colBankaSubeId.Caption = "BankaSubeId";
            this.colBankaSubeId.FieldName = "BankaSubeId";
            this.colBankaSubeId.MinWidth = 25;
            this.colBankaSubeId.Name = "colBankaSubeId";
            this.colBankaSubeId.OptionsColumn.AllowEdit = false;
            this.colBankaSubeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaSubeId.OptionsFilter.AllowAutoFilter = false;
            this.colBankaSubeId.OptionsFilter.AllowFilter = false;
            this.colBankaSubeId.StatusBarAciklama = null;
            this.colBankaSubeId.StatusBarKisaYol = null;
            this.colBankaSubeId.StatusBarKisaYolAciklama = null;
            this.colBankaSubeId.Width = 90;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube Adı";
            this.colBankaSubeAdi.ColumnEdit = this.repositoryItemButtonBankaSube;
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.MinWidth = 25;
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaSubeAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaSubeAdi.OptionsFilter.AllowFilter = false;
            this.colBankaSubeAdi.StatusBarAciklama = "Banka Şube Seçiniz.";
            this.colBankaSubeAdi.StatusBarKisaYol = "F4 : ";
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colBankaSubeAdi.Width = 150;
            // 
            // repositoryItemButtonBankaSube
            // 
            this.repositoryItemButtonBankaSube.AutoHeight = false;
            this.repositoryItemButtonBankaSube.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonBankaSube.Name = "repositoryItemButtonBankaSube";
            this.repositoryItemButtonBankaSube.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.MinWidth = 25;
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colBelgeNo.OptionsFilter.AllowAutoFilter = false;
            this.colBelgeNo.OptionsFilter.AllowFilter = false;
            this.colBelgeNo.StatusBarAciklama = "Belge No Giriniz.";
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Width = 95;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.MinWidth = 25;
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colHesapNo.OptionsFilter.AllowAutoFilter = false;
            this.colHesapNo.OptionsFilter.AllowFilter = false;
            this.colHesapNo.StatusBarAciklama = "Hesap No Giriniz.";
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Width = 150;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asıl Borçlu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.MinWidth = 25;
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.OptionsColumn.ShowInCustomizationForm = false;
            this.colAsilBorclu.OptionsFilter.AllowAutoFilter = false;
            this.colAsilBorclu.OptionsFilter.AllowFilter = false;
            this.colAsilBorclu.StatusBarAciklama = "Asıl Borçlu Giriniz.";
            this.colAsilBorclu.StatusBarKisaYol = null;
            this.colAsilBorclu.StatusBarKisaYolAciklama = null;
            this.colAsilBorclu.Width = 150;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.MinWidth = 25;
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.OptionsColumn.ShowInCustomizationForm = false;
            this.colCiranta.OptionsFilter.AllowAutoFilter = false;
            this.colCiranta.OptionsFilter.AllowFilter = false;
            this.colCiranta.StatusBarAciklama = "Ciranta Giriniz.";
            this.colCiranta.StatusBarKisaYol = null;
            this.colCiranta.StatusBarKisaYolAciklama = null;
            this.colCiranta.Width = 150;
            // 
            // colTutarYazi
            // 
            this.colTutarYazi.Caption = "TutarYazi";
            this.colTutarYazi.FieldName = "TutarYazi";
            this.colTutarYazi.MinWidth = 25;
            this.colTutarYazi.Name = "colTutarYazi";
            this.colTutarYazi.OptionsColumn.AllowEdit = false;
            this.colTutarYazi.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutarYazi.OptionsFilter.AllowAutoFilter = false;
            this.colTutarYazi.OptionsFilter.AllowFilter = false;
            this.colTutarYazi.StatusBarAciklama = null;
            this.colTutarYazi.StatusBarKisaYol = null;
            this.colTutarYazi.StatusBarKisaYolAciklama = null;
            this.colTutarYazi.Width = 150;
            // 
            // colVadeYazi
            // 
            this.colVadeYazi.Caption = "VadeYazi";
            this.colVadeYazi.FieldName = "VadeYazi";
            this.colVadeYazi.MinWidth = 25;
            this.colVadeYazi.Name = "colVadeYazi";
            this.colVadeYazi.OptionsColumn.AllowEdit = false;
            this.colVadeYazi.OptionsColumn.ShowInCustomizationForm = false;
            this.colVadeYazi.OptionsFilter.AllowAutoFilter = false;
            this.colVadeYazi.OptionsFilter.AllowFilter = false;
            this.colVadeYazi.StatusBarAciklama = null;
            this.colVadeYazi.StatusBarKisaYol = null;
            this.colVadeYazi.StatusBarKisaYolAciklama = null;
            this.colVadeYazi.Width = 150;
            // 
            // colBelgeDurumu
            // 
            this.colBelgeDurumu.Caption = "Belge Durumu";
            this.colBelgeDurumu.FieldName = "BelgeDurumu";
            this.colBelgeDurumu.MinWidth = 25;
            this.colBelgeDurumu.Name = "colBelgeDurumu";
            this.colBelgeDurumu.OptionsColumn.AllowEdit = false;
            this.colBelgeDurumu.OptionsFilter.AllowAutoFilter = false;
            this.colBelgeDurumu.OptionsFilter.AllowFilter = false;
            this.colBelgeDurumu.StatusBarAciklama = null;
            this.colBelgeDurumu.StatusBarKisaYol = null;
            this.colBelgeDurumu.StatusBarKisaYolAciklama = null;
            this.colBelgeDurumu.Visible = true;
            this.colBelgeDurumu.VisibleIndex = 9;
            this.colBelgeDurumu.Width = 200;
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
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 250;
            // 
            // colSonHareketTarihi
            // 
            this.colSonHareketTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonHareketTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonHareketTarihi.Caption = "Son İşlem Tarihi";
            this.colSonHareketTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colSonHareketTarihi.FieldName = "SonHareketTarihi";
            this.colSonHareketTarihi.MinWidth = 25;
            this.colSonHareketTarihi.Name = "colSonHareketTarihi";
            this.colSonHareketTarihi.OptionsColumn.AllowEdit = false;
            this.colSonHareketTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colSonHareketTarihi.OptionsFilter.AllowFilter = false;
            this.colSonHareketTarihi.StatusBarAciklama = null;
            this.colSonHareketTarihi.StatusBarKisaYol = null;
            this.colSonHareketTarihi.StatusBarKisaYolAciklama = null;
            this.colSonHareketTarihi.Visible = true;
            this.colSonHareketTarihi.VisibleIndex = 11;
            this.colSonHareketTarihi.Width = 110;
            // 
            // colSonIslemYeri
            // 
            this.colSonIslemYeri.Caption = "Son İşlem Yeri";
            this.colSonIslemYeri.FieldName = "SonIslemYeri";
            this.colSonIslemYeri.MinWidth = 25;
            this.colSonIslemYeri.Name = "colSonIslemYeri";
            this.colSonIslemYeri.OptionsColumn.AllowEdit = false;
            this.colSonIslemYeri.OptionsFilter.AllowAutoFilter = false;
            this.colSonIslemYeri.OptionsFilter.AllowFilter = false;
            this.colSonIslemYeri.StatusBarAciklama = null;
            this.colSonIslemYeri.StatusBarKisaYol = null;
            this.colSonIslemYeri.StatusBarKisaYolAciklama = null;
            this.colSonIslemYeri.Visible = true;
            this.colSonIslemYeri.VisibleIndex = 12;
            this.colSonIslemYeri.Width = 200;
            // 
            // OdemeBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "OdemeBilgileriTable";
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBankaHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateVade.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateVade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonBankaSube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colPortFoyNo;
        private Grids.MyGridColumn colOdemeTuruAdi;
        private Grids.MyGridColumn colBankaHesapAdi;
        private Grids.MyGridColumn colGirisTarihi;
        private Grids.MyGridColumn colVade;
        private Grids.MyGridColumn colTahsil;
        private Grids.MyGridColumn colTahsilde;
        private Grids.MyGridColumn colIade;
        private Grids.MyGridColumn colKalan;
        private Grids.MyGridColumn colBankaId;
        private Grids.MyGridColumn colBankaAdi;
        private Grids.MyGridColumn colBankaSubeId;
        private Grids.MyGridColumn colBankaSubeAdi;
        private Grids.MyGridColumn colBelgeNo;
        private Grids.MyGridColumn colHesapNo;
        private Grids.MyGridColumn colAsilBorclu;
        private Grids.MyGridColumn colCiranta;
        private Grids.MyGridColumn colTutarYazi;
        private Grids.MyGridColumn colVadeYazi;
        private Grids.MyGridColumn colAciklama;
        private Grids.MyGridColumn colBelgeDurumu;
        private Grids.MyGridColumn colSonHareketTarihi;
        private Grids.MyGridColumn colSonIslemYeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBankaHesap;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateVade;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBanka;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonBankaSube;
        private Grids.MyGridColumn colTakipNo;
        private Grids.MyGridColumn colTutar;
        private Grids.MyGridColumn colBlokeGunSayisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit;
        private Grids.MyGridColumn colBankaHesapId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
    }
}
