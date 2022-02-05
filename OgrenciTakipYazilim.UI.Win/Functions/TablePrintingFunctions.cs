﻿using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.GenelForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public class TablePrintingFunctions
    {
        private static GridView _tablo;
        private static string _subeAdi;
        private static PrintableComponentLink _link;
        private static PrintingSystem _ps;
        private static DokumParametleri _dp;

        public static void Yazdir(GridView tablo, string raporBaslik, string subeAdi)
        {
            _link = new PrintableComponentLink();
            _ps = new PrintingSystem();
            _tablo = tablo;
            _subeAdi = subeAdi;
            _dp = ShowEditForms<TabloDokumParametreleri>.ShowDialogEditFrom<DokumParametleri>(raporBaslik);

            RaporDokumu();
        }

        private static void RaporDokumu()
        {
            BaslikEkle();
            RaporuKagidaSigdir();

            _tablo.OptionsPrint.PrintHorzLines = _dp.YatayCizgileriGoster == EvetHayir.Evet;
            _tablo.OptionsPrint.PrintHorzLines = _dp.DikeyCizgileriGoster == EvetHayir.Evet;
            _tablo.OptionsPrint.PrintHorzLines = _dp.SutunBaslikGoster == EvetHayir.Evet;
            _tablo.OptionsView.ShowViewCaption = false;

            _link.Component = _tablo.GridControl;
            _link.PaperKind = PaperKind.Letter;
            _link.Margins = new Margins(59, 59, 115, 48);
            _link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
            _link.CreateDocument(_ps);

            switch (_dp.DokumSekli)
            {
                case DokumSekli.TabloBaskiOnİzleme:
                    ShowRibbonForms<RaporOnIzleme>.ShowFrom(true, _ps, _dp.RaporBaslik);
                    break;
                case DokumSekli.TabloYazdir:
                    for (int i = 0; i < _dp.YazdirilacakAdet; i++)
                        _link.Print(_dp.YaziciAdi);
                    break;
            }

            _tablo.OptionsView.ShowViewCaption = true;
        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir) return;

            var boldFont = new Font("Tahoma", 7, FontStyle.Bold);
            var regulerFont = new Font("Tahoma", 7, FontStyle.Regular);

            #region SayfaBrick
            var sayfaBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regulerFont,
                PageInfo = PageInfo.NumberOfTotal,
                Format = "Sayfa : {0} / {1}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true,
            };

            _ps.Graph.DrawBrick(sayfaBrick, new RectangleF(200, 25, 40, 15));
            #endregion

            #region TarihBrick
            var tarihBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regulerFont,
                PageInfo = PageInfo.DateTime,
                Format = "Tarih : {0:dd.MM.yyyy}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true,
            };

            _ps.Graph.DrawBrick(tarihBrick, new RectangleF(0, 40, 50, 15));
            #endregion

            #region SubeBaslikValueBrick
            var subeBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Şube"
            };

            _ps.Graph.DrawBrick(subeBaslikBrick, new RectangleF(0, 25, 40, 15));

            var subeValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regulerFont,
                Text = $": {_subeAdi}"
            };

            _ps.Graph.DrawBrick(subeValueBrick, new RectangleF(55, 25, 500, 15));
            #endregion

            #region DonemBaslikValueBrick
            var donemBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldFont,
                Text = "Dönem"
            };

            _ps.Graph.DrawBrick(donemBaslikBrick, new RectangleF(0, 40, 40, 15));

            var donemValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regulerFont,
                Text = $": {AnaForm.DonemAdi}"
            };

            _ps.Graph.DrawBrick(donemValueBrick, new RectangleF(55, 40, 200, 15)); 
            #endregion
        }

        private static void BaslikEkle()
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir)
            {
                return;
            }
            var headerArea = new PageHeaderArea();
            headerArea.Content.AddRange(new[] { "", _dp.RaporBaslik, "" });
            headerArea.Font = new Font("Arial Narrow", 10f, FontStyle.Bold);
            headerArea.LineAlignment = BrickAlignment.Far;
            _link.PageHeaderFooter = new PageHeaderFooter(headerArea, null);
        }

        private static void RaporuKagidaSigdir()
        {
            YazdirmaYonuAyarla();

            switch (_dp.RaporKagidaSigdirmaTuru)
            {
                case RaporKagidaSigdirmaTuru.SutunDaraltarakSigdir:
                    _tablo.OptionsPrint.AutoWidth = true;
                    break;
                case RaporKagidaSigdirmaTuru.YaziBoyutKuculterekSigdir:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.AutoFitToPagesWidth = 1;
                    break;
                default:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.ScaleFactor = 1.0f;
                    break;
            }
        }

        private static void YazdirmaYonuAyarla()
        {
            switch (_dp.YazdirmaYonu)
            {
                case YazdirmaYonu.Dikey:
                    _link.Landscape = false;
                    break;
                case YazdirmaYonu.Yatay:
                    _link.Landscape = true;
                    break;
                case YazdirmaYonu.Otomatik:
                    _link.Landscape = OtomatikYazdirmaYonu();
                    break;
            }
        }

        private static bool OtomatikYazdirmaYonu()
        {
            const int sayfaGenisligi = 703;
            var tabloSutunGenislikleri = 0;

            for (int i = 0; i < _tablo.Columns.Count; i++)
                if (_tablo.Columns[i].Visible)
                    tabloSutunGenislikleri += _tablo.Columns[i].Width;

            return tabloSutunGenislikleri > sayfaGenisligi;
        }
    }
}