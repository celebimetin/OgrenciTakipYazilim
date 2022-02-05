using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Common.Functions;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.BankaForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaHesapForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaSubeForms;
using OgrenciTakipYazilim.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakipYazilim.UI.Win.Forms.KasaForms;
using OgrenciTakipYazilim.UI.Win.Forms.OkulForms;
using OgrenciTakipYazilim.UI.Win.Forms.YakinlikForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public static class SelectRepositoryFunctions
    {
        private static GridView _tablo;
        private static ControlNavigator _controlNavigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;

        private static void RemoveEvents()
        {
            if (_buttonEdit == null) return;

            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            _tablo.KeyDown -= Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator controlNavigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvents();
            _tablo = tablo;
            _controlNavigator = controlNavigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator controlNavigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmIdColumn, GridColumn prmNameColumn)
        {
            RemoveEvents();
            _tablo = tablo;
            _controlNavigator = controlNavigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _prmIdColumn = prmIdColumn;
            _nameColumn = nameColumn;
            _prmNameColumn = prmNameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
                case "repositoryItemButtonYakinlik":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);

                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemButtonBanka":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);

                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemButtonBankaSube":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);
                        var bankaId = _tablo.GetRowCellId(_prmIdColumn);
                        var bankaAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, id, bankaId, bankaAdi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.SubeAdi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemButtonBankaHesap":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);
                        var odemeTipi = _tablo.GetFocusedRowCellValue("OdemeTipi").ToString().GetEnum<OdemeTipi>();

                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, odemeTipi);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                            _tablo.SetFocusedRowCellValue("BlokeGunSayisi", entity.BlokeGunSayisi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemIptalNedeni":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);

                        var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedenAdi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemGittigiOkul":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _tablo.GetRowCellId(_idColumn);

                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.OkulAdi);
                            _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemButtonHesap":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);

                        switch (_tablo.GetRow<GeriOdemeBilgileriL>().HesapTuru)
                        {
                            case GeriOdemeHesapTuru.Banka:
                                {
                                    var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, OdemeTipi.Elden);

                                    if (entity == null) return;

                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                                    _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);

                                    break;
                                }
                            case GeriOdemeHesapTuru.Kasa:
                                {
                                    var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, id);

                                    if (entity == null) return;

                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.KasaAdi);
                                    _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);

                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private static void ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _controlNavigator.Buttons.DoClick(_controlNavigator.Buttons.EndEdit);
                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }
    }
}