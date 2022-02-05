using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.Model.Entities.Base;
using OgrenciTakipYazilim.UI.Win.Forms.FiltreForms;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.ShowForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using DevExpress.Utils.Extensions;
using OgrenciTakipYazilim.Common.Messages;

namespace OgrenciTakipYazilim.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseShowForm ShowForm;
        protected KartTuru BaseListKartTuru;
        protected IBaseBll BllList;
        protected ControlNavigator Navigator;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool AktifKartlariGoster = true;
        protected internal GridView Tablo;
        protected internal BaseEntity SelectedEntity;
        protected internal IList<BaseEntity> SelectedEntities;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool MultiSelect;
        protected internal long? SeciliGelecekId;
        protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected internal SelectRowFunctions RowSelect;
        protected internal bool EklenebilecekEntityVar = false;

        public BaseListForm()
        {
            InitializeComponent();
        }

        private void FiltreSec()
        {
            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseListKartTuru, Tablo.GridControl);
            if (entity == null)
            {
                return;
            }
            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }
        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }
            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }
            Listele();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                EntitySelect();
            }
            else
            {
                btnDuzelt.PerformClick();
            }
        }
        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster
                ? BarItemVisibility.Never
                : IsMdiChild
                ? BarItemVisibility.Never
                : BarItemVisibility.Always;

            barEnter.Visibility = IsMdiChild
                ? BarItemVisibility.Never
                : BarItemVisibility.Always;

            barEnterAciklama.Visibility = IsMdiChild
                ? BarItemVisibility.Never
                : BarItemVisibility.Always;

            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster
                ? BarItemVisibility.Always
                : !IsMdiChild
                ? BarItemVisibility.Never
                : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        private void SutunGizleGoster()
        {

        }
        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }
            if (_tabloSablonKayitEdilecek)
            {
                Tablo.TabloSablonKaydet(IsMdiChild
                    ? Name + "Tablosu"
                    : Name + "TablosuMDI");
            }
        }
        private void SablonYukle()
        {
            if (IsMdiChild)
            {
                Tablo.TabloSablonYukle(Name + "Tablosu");
            }
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + "TablosuMDI");
            }
        }
        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0)
            {
                return;
            }
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }
        protected virtual void ShowEditForm(long id)
        {
            long result = ShowForm.ShowDialogEditFrom(BaseListKartTuru, id);
            ShowEditFormDefault(result);
        }
        protected virtual void DegiskenleriDoldur() { }
        protected virtual void Listele() { }
        protected virtual void BagliKartlariAc() { }
        protected virtual void EntitySelect()
        {
            if (MultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();
                if (RowSelect.SelectedRowCount == 0)
                {
                    Messages.KartUyarıMesaji();
                    return;
                }

                SelectedEntities = RowSelect.GetSelectedRows();
            }
            else
                SelectedEntity = Tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }
        protected virtual void EntityDelete()
        {
            BaseEntity entity = Tablo.GetRow<BaseEntity>();
            if (entity == null)
            {
                return;
            }
            if (!((IBaseCommonBll)BllList).Delete(entity))
            {
                return;
            }

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
        }
        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;
        }
        protected virtual void TahakkukYap() { }

        private void EventsLoad()
        {
            //Button Events
            foreach (object item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;

            //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                BarSubItemLink link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatliExcelDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatsizExcelDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption, Text);
            }
            else if (e.Item == btnWordDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnPdfDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnTxtDosyasi)
            {
                Tablo.TabloVerileriDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnYeni)
            {
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                EntitySelect();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
            {
                FiltreSec();
            }
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                {
                    Tablo.ShowCustomization();
                }
                else
                {
                    Tablo.HideCustomization();
                }
            }
            else if (e.Item == btnTahakkukYap)
            {
                TahakkukYap();
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartlariAc();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_FilterEditorCreated(object sender, FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogEditFrom(KartTuru.Filtre, _filtreId, BaseListKartTuru, Tablo.GridControl);
        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
            {
                _filtreId = 0;
            }
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter)
            {
                return;
            }

            if (e.Column.Summary.Count > 0)
            {
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            }
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
            //SutunGizleGoster();

            if (IsMdiChild || SeciliGelecekId == null)
            {
                return;
            }
            Tablo.RowFocus("Id", SeciliGelecekId);
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }

        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
            {
                _formSablonKayitEdilecek = true;
            }
        }

        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
            {
                _formSablonKayitEdilecek = true;
            }
        }
    }
}