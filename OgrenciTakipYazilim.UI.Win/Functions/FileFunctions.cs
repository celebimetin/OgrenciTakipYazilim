using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonAdi, int left, int top, int width, int height, FormWindowState windowState)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");
                }

                XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
                XmlWriter writer = XmlWriter.Create(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }_location.xml", settings);
                writer.WriteStartDocument();
                writer.WriteComment("Abc Yazılım tarafından oluşturuldu.");
                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", left.ToString());
                writer.WriteAttributeString("Top", top.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("FormSize");
                if (windowState == FormWindowState.Maximized)
                {
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("Width", width.ToString());
                    writer.WriteAttributeString("Height", height.ToString());
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Messages.HataMesaji(e.Message);
            }
        }

        public static void FormSablonYukle(this string sablonAdi, XtraForm frm)
        {
            List<string> list = new List<string>();

            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }_location.xml"))
                {
                    XmlReader reader = XmlReader.Create(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }_location.xml");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                    }

                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {
                Messages.HataMesaji(e.Message);
            }

            if (list.Count <= 0)
            {
                return;
            }

            frm.Location = new Point(int.Parse(list[0]), int.Parse(list[1]));

            if (list[2] == "-1" && list[3] == "-1")
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.Size = new Size(int.Parse(list[2]), int.Parse(list[3]));
            }
        }

        public static void TabloSablonKaydet(this GridView tablo, string sablonAdi)
        {
            try
            {
                tablo.ClearColumnsFilter();

                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");
                }

                tablo.SaveLayoutToXml(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }.xml");
            }
            catch (Exception e)
            {
                Messages.HataMesaji(e.Message);
            }
        }

        public static void TabloSablonYukle(this GridView tablo, string sablonAdi)
        {
            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }.xml"))
                {
                    tablo.RestoreLayoutFromXml(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi }.xml");
                }
            }
            catch (Exception e)
            {
                Messages.HataMesaji(e.Message);
            }
        }

        public static void TabloVerileriDisariAktar(this GridView tablo, DosyaTuru dosyaTuru, string dosyaFormati, string excelSayfadi = null)
        {
            if (Messages.TabloExportMesaj(dosyaFormati) != DialogResult.Yes)
            {
                return;
            }
            if (!Directory.Exists(Application.StartupPath + @"\Temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Temp");
            }

            string dosyaAdi = Guid.NewGuid().ToString();
            string filePath = $@"{Application.StartupPath}\Temp\{dosyaAdi}";

            switch (dosyaTuru)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        XlsxExportOptionsEx options = new XlsxExportOptionsEx
                        {
                            ExportType = ExportType.Default,
                            SheetName = excelSayfadi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, options);
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        XlsxExportOptionsEx options = new XlsxExportOptionsEx
                        {
                            ExportType = ExportType.WYSIWYG,
                            SheetName = excelSayfadi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, options);
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        CsvExportOptionsEx options = new CsvExportOptionsEx
                        {
                            ExportType = ExportType.WYSIWYG,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Csv";
                        tablo.ExportToCsv(filePath, options);
                    }
                    break;
                case DosyaTuru.WordDosyasi:
                    {
                        filePath = filePath + ".Rtf";
                        tablo.ExportToRtf(filePath);
                    }
                    break;
                case DosyaTuru.PdfDosyasi:
                    {
                        filePath = filePath + ".Pdf";
                        tablo.ExportToPdf(filePath);
                    }
                    break;
                case DosyaTuru.TxtDosyasi:
                    {
                        TextExportOptions options = new TextExportOptions
                        {
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Txt";
                        tablo.ExportToText(filePath, options);
                    }
                    break;
            }

            if (!File.Exists(filePath))
            {
                Messages.HataMesaji("Tablo Verileri Dosya'ya Aktarılamadı.");
                return;
            }

            Process.Start(filePath);
        }
    }
}