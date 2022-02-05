using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakipYazilim.Bll.Base.Interfaces;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Entities.Base;
using OgrenciTakipYazilim.UI.Win.Functions;
using OgrenciTakipYazilim.UI.Win.Interfaces;
using OgrenciTakipYazilim.UI.Win.UserControls.Controls;
using OgrenciTakipYazilim.UI.Win.UserControls.Grids;
using System;
using System.Windows.Forms;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;

namespace OgrenciTakipYazilim.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        private bool _formSablonKayitEdilecek;
        protected IBaseBll BllEdit;
        protected KartTuru BaseEditKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool Isloaded;
        protected bool KayitSonrasıFormuKapat = true;
        protected internal IslemTuru BaseEditIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYap;
        protected bool FarkliSubeIslem;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseEditIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                        {
                            return KayitSonrasiIslemler();
                        }
                        break;

                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                        {
                            return KayitSonrasiIslemler();
                        }
                        break;
                }

                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYap = true;
                    ButtonEnabledDurumu();

                    if (KayitSonrasıFormuKapat)
                    {
                        Close();
                    }
                    else
                    {
                        BaseEditIslemTuru = BaseEditIslemTuru == IslemTuru.EntityInsert
                            ? IslemTuru.EntityUpdate
                            : BaseEditIslemTuru;
                    }
                    return true;
                }
                return false;
            }

            DialogResult dialogResult = kapanis
                ? Messages.KapanisMesaj()
                : Messages.KayitMesaj();

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                    return true;

                case DialogResult.Cancel:
                    return false;
            }
            return false;
        }
        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayır("Bu Filtre Referans Alarak Yeni Bir Kayıt Oluşturacaktır. Onaylıyor musunuz.?", "Kayıt Onay") != DialogResult.Yes)
            {
                BaseEditIslemTuru = IslemTuru.EntityInsert;
                Yukle();
                if (Kaydet(true))
                    Close();
            }
        }
        private void EntityDelete()
        {
            if (!((IBaseCommonBll)BllEdit).Delete(OldEntity))
            {
                return;
            }
            RefreshYap = true;
            Close();
        }
        private void GeriAl()
        {
            if (Messages.HayırSeciliEvetHayır("Yapılan Değişiklikler Geri Alınacaktır. Onaylıyormusunuz?", "Geri Al Onay") != DialogResult.Yes)
            {
                return;
            }
            else if (BaseEditIslemTuru == IslemTuru.EntityUpdate)
            {
                Yukle();
            }
            else
            {
                Close();
            }
        }
        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }
        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        protected void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }
        }
        protected virtual void TabloYukle() { }
        protected virtual void NesneKontrollereBagla() { }
        protected virtual void GuncelNesneOlustur() { }
        protected virtual void SecimYap(object sender) { }
        protected virtual void FiltreUygula() { }
        protected virtual void TaksitOlustur() { }
        protected virtual void Yazdir() { }
        protected virtual void BaskiOnIzleme() { }
        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)BllEdit).Insert(CurrentEntity);
        }
        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)BllEdit).Update(OldEntity, CurrentEntity);
        }
        protected internal virtual void Yukle() { }
        protected internal virtual IBaseEntity ReturnEntity() { return null; }
        protected internal virtual void ButtonEnabledDurumu()
        {
            if (!Isloaded) return;
            GeneralFunctionsWin.ButtonEnabledDurumu(btnKaydet, btnGeriAl, btnYeni, btnSil, OldEntity, CurrentEntity);
        }
        protected virtual void BagliTabloYukle() { }
        protected virtual bool BagliTabloKaydet() { return false; }
        protected virtual bool BagliTabloHataliGirisControl() { return false; }

        protected void EventsLoad()
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
            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            //Control Events
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case FilterControl filterControl:
                        filterControl.FilterChanged += Control_EditValueChanged;
                        break;

                    case ComboBoxEdit comboBoxEdit:
                        comboBoxEdit.EditValueChanged += Control_EditValueChanged;
                        comboBoxEdit.SelectedValueChanged += Control_SelectedValueChanged;
                        break;

                    case MyButtonEdit myButtonEdit:
                        myButtonEdit.IdChanged += ControlMyButtonEdit_IdChanged;
                        myButtonEdit.EnabledChange += ControlMyButtonEdit_EnabledChange;
                        myButtonEdit.ButtonClick += ControlMyButtonEdit_ButtonClick;
                        myButtonEdit.DoubleClick += ControlMyButtonEdit_DoubleClick;
                        break;

                    case BaseEdit baseEdit:
                        baseEdit.EditValueChanged += Control_EditValueChanged;
                        break;

                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;

                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
            {
                foreach (MyDataLayoutControl layout in DataLayoutControls)
                {
                    foreach (Control ctrl in layout.Controls)
                    {
                        ControlEvents(ctrl);
                    }
                }
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni)
            {
                BaseEditIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item == btnFarkliKaydet)
            {
                FarkliKaydet();
            }
            else if (e.Item == btnGeriAl)
            {
                GeriAl();
            }
            else if (e.Item == btnSil)
            {
                EntityDelete();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnUygula)
            {
                FiltreUygula();
            }
            else if (e.Item == btnTaksitOlustur)
            {
                TaksitOlustur();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnIzleme();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (sender is MyButtonEdit myButtonEdit)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        myButtonEdit.Id = null;
                        myButtonEdit.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(myButtonEdit);
                        break;
                }
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisaYol.Visibility = BarItemVisibility.Never;
            statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }

        protected virtual void Control_Enter(object sender, EventArgs e) { }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            Type type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit))
            {
                statusBarKisaYol.Visibility = BarItemVisibility.Always;
                statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }
            else if (sender is IStatusBarAciklama value)
            {
                statusBarAciklama.Caption = value.StatusBarAciklama;
            }
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            Isloaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();

            if (FarkliSubeIslem)
                Messages.UyarıMesaji("İşlem Yapılan Kart Çalışılan Şube veya Dönem Olmadığı için Yapılan Değişiklikler Kayıt Edilmez.!");
        }

        protected virtual void ControlMyButtonEdit_IdChanged(object sender, MyButtonEdit.IdChangedEventArgs e)
        {
            if (!Isloaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void ControlMyButtonEdit_EnabledChange(object sender, EventArgs e) { }

        private void ControlMyButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void ControlMyButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!Isloaded) return;
            GuncelNesneOlustur();
        }

        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;
            if (!Kaydet(true))
                e.Cancel = true;
        }

        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }
    }
}