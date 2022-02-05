using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.Model.Entities.Base;
using OgrenciTakipYazilim.UI.Win.UserControls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public static class GeneralFunctionsWin
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartUyarıMesaji();

            return -1;
        }

        public static long GetRowCellId(this GridView tablo, GridColumn idColumn)
        {
            var value = tablo.GetRowCellValue(tablo.FocusedRowHandle, idColumn);
            return (long?) value ?? -1;
        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajVer)
                Messages.KartUyarıMesaji();
            
            return default(T);
        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);
            Messages.KartUyarıMesaji();

            return default(T);
        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T currentEntity)
        {
            foreach (PropertyInfo item in currentEntity.GetType().GetProperties())
            {
                if (item.PropertyType.Namespace == "System.Collections.Generic")
                {
                    continue;
                }
                object oldValue = item.GetValue(oldEntity) ?? string.Empty;
                object currentValue = item.GetValue(currentEntity) ?? string.Empty;

                if (item.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                    {
                        oldValue = new byte[] { 0 };
                    }
                    if (string.IsNullOrEmpty(currentValue.ToString()))
                    {
                        currentValue = new byte[] { 0 };
                    }

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                    {
                        return VeriDegisimYeri.Alan;
                    }
                }
                else if (!currentValue.Equals(oldValue))
                {
                    return VeriDegisimYeri.Alan;
                }
            }
            return VeriDegisimYeri.VeriDegisimYok;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnYeni, BarButtonItem btnSil, T oldEntity, T currentEntity)
        {
            VeriDegisimYeri veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);

            bool buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnGeriAl.Enabled = buttonEnabledDurum;
            btnYeni.Enabled = !buttonEnabledDurum;
            btnSil.Enabled = !buttonEnabledDurum;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnYeni, BarButtonItem btnSil, T oldEntity, T currentEntity, bool tableValueChanged)
        {
            VeriDegisimYeri veriDegisimYeri = tableValueChanged ? VeriDegisimYeri.Alan : VeriDegisimYeriGetir(oldEntity, currentEntity);

            bool buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnGeriAl.Enabled = buttonEnabledDurum;
            btnYeni.Enabled = !buttonEnabledDurum;
            btnSil.Enabled = !buttonEnabledDurum;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru,T oldEntity, T currentEntity)
        {
            VeriDegisimYeri veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, currentEntity);
            bool buttonEnabledDurum = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurum;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabledDurum;
        }

        public static void ButtonEnabledDurumu(BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnYeni, BarButtonItem btnSil)
        {
            btnKaydet.Enabled = false;
            btnGeriAl.Enabled = false;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            string SifirEkle(string sayi)
            {
                if (sayi.Length == 1)
                {
                    return "0" + sayi;
                }
                return sayi;
            }

            string UcBasamakYap(string sayi)
            {
                switch (sayi.Length)
                {
                    case 1:
                        return "00" + sayi;
                    case 2:
                        return "0" + sayi;
                }
                return sayi;
            }

            string Id()
            {
                string year = DateTime.Now.Date.Year.ToString();
                string month = SifirEkle(DateTime.Now.Date.Month.ToString());
                string day = SifirEkle(DateTime.Now.Date.Day.ToString());
                string hour = SifirEkle(DateTime.Now.Hour.ToString());
                string minute = SifirEkle(DateTime.Now.Minute.ToString());
                string second = SifirEkle(DateTime.Now.Second.ToString());
                string millisecond = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                string random = SifirEkle(new Random().Next(0, 99).ToString());

                return year + month + day + hour + minute + second + millisecond + random;
            }

            return islemTuru == IslemTuru.EntityUpdate
                ? selectedEntity.Id
                : long.Parse(Id());
        }

        public static void ControlEnabledChange(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit myButtonEdit:
                    myButtonEdit.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;
                    myButtonEdit.Id = null;
                    myButtonEdit.EditValue = null;
                    break;
            }
        }

        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            int rowHandle = 0;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                object bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);
                if (aranacakDeger.Equals(bulunanDeger))
                {
                    rowHandle = i;
                }
                tablo.FocusedRowHandle = rowHandle;
            }
        }

        public static void RowFocus(this GridView tablo, int rowHandle)
        {
            if (rowHandle <= 0)
            {
                return;
            }
            if (rowHandle == tablo.RowCount - 1)
            {
                tablo.FocusedRowHandle = rowHandle;
            }
            else
            {
                tablo.FocusedRowHandle = rowHandle - 1;
            }
        }

        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static List<string> YazicileriListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void ShowPopupMenu(this MouseEventArgs e, PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları (*.bmp, *.gif, *.jpg, *.png) | *.bmp; *.gif; *.jpg; *.png |Bmp Dosyaları|*.bmp |Gif Dosyaları|*.gif |Jpg Dosyaları|*.jpg |Png Dosyları|*.png",
                InitialDirectory = @"C:\",
            };

            byte[] Resim()
            {
                using (var memoryStream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }
            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if(!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if(entity == null) return;
                if(!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;
            }
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHaraketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static BaseTablo AddTablo(this BaseTablo tablo, BaseEditForm frm)
        {
            tablo.Dock = DockStyle.Fill;
            tablo.OwnerForm = frm;
            return tablo;
        }

        public static void LayoutControlInsert(this LayoutGroup layoutGroup, Control control, int columnIndex, int rowIndex,
            int columnSpan, int rowSpan)
        {
            var item = new LayoutControlItem
            {
                Control = control,
                Parent = layoutGroup,
            };

            item.OptionsTableLayoutItem.ColumnIndex = columnIndex;
            item.OptionsTableLayoutItem.RowIndex = rowIndex;
            item.OptionsTableLayoutItem.ColumnSpan = columnSpan;
            item.OptionsTableLayoutItem.RowSpan = rowSpan;
        }

        public static void RowCellEnabled(this GridView tablo)
        {
            var rowHandle = tablo.FocusedRowHandle;

            tablo.FocusedRowHandle = 0;
            tablo.ClearSelection();

            tablo.FocusedRowHandle = rowHandle;
        }
    }
}