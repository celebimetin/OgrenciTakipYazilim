﻿using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities;
using OgrenciTakipYazilim.UI.Win.Forms.IlceForms;
using OgrenciTakipYazilim.UI.Win.Forms.IlForms;
using OgrenciTakipYazilim.UI.Win.ShowForms;
using OgrenciTakipYazilim.UI.Win.UserControls.Controls;
using System;
using OgrenciTakipYazilim.Model.Dto;
using OgrenciTakipYazilim.UI.Win.Forms.BankaForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaHesapForms;
using OgrenciTakipYazilim.UI.Win.Forms.BankaSubeForms;
using OgrenciTakipYazilim.UI.Win.Forms.GorevForms;
using OgrenciTakipYazilim.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.IsyeriForms;
using OgrenciTakipYazilim.UI.Win.Forms.KontenjanForms;
using OgrenciTakipYazilim.UI.Win.Forms.MeslekForms;
using OgrenciTakipYazilim.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakipYazilim.UI.Win.Forms.OkulForms;
using OgrenciTakipYazilim.UI.Win.Forms.OzelKodForms;
using OgrenciTakipYazilim.UI.Win.Forms.RehberForms;
using OgrenciTakipYazilim.UI.Win.Forms.SinifForms;
using OgrenciTakipYazilim.UI.Win.Forms.SinifGrupForms;
using OgrenciTakipYazilim.UI.Win.Forms.TesvikForms;
using OgrenciTakipYazilim.UI.Win.Forms.YabanciDilForms;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru _kartTuru;
        private OdemeTipi _odemeTipi;

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, OdemeTipi odemeTipi)
        {
            _btnEdit = btnEdit;
            _odemeTipi = odemeTipi;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod1, _kartTuru);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtIl":
                case "txtEvAdresIl":
                case "txtIsAdresIl":
                case "txtKimlikIl":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "txtIlce":
                case "txtEvAdresIlce":
                case "txtIsAdresIlce":
                case "txtKimlikIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;

                case "txtGrup":
                    {
                        var entity = (SinifGrup)ShowListForms<SinifGrupListForm>.ShowDialogListForm(KartTuru.SinifGrup, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupAdi;
                        }
                    }
                    break;

                case "txtHizmetTuru":
                    {
                        var entity = (HizmetTuru)ShowListForms<HizmetTuruListForm>.ShowDialogListForm(KartTuru.HizmetTuru, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HizmetTuruAdi;
                        }
                    }
                    break;

                case "txtBanka":
                    {
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankaAdi;
                        }
                    }
                    break;

                case "txtBankaSube":
                    {
                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;

                case "txtMeslek":
                    {
                        var entity = (Meslek)ShowListForms<MeslekListForm>.ShowDialogListForm(KartTuru.Meslek, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MeslekAdi;
                        }
                    }
                    break;

                case "txtIsyeri":
                    {
                        var entity = (Isyeri)ShowListForms<IsyeriListForm>.ShowDialogListForm(KartTuru.Isyeri, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsyeriAdi;
                        }
                    }
                    break;

                case "txtGorev":
                    {
                        var entity = (Gorev)ShowListForms<GorevListForm>.ShowDialogListForm(KartTuru.Gorev, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GorevAdi;
                        }
                    }
                    break;

                case "txtIndirimTuru":
                    {
                        var entity = (IndirimTuru)ShowListForms<IndirimTuruListForm>.ShowDialogListForm(KartTuru.IndirimTuru, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IndirimTuruAdi;
                        }
                    }
                    break;

                case "txtSinif":
                    {
                        var entity = (SinifL)ShowListForms<SinifListForm>.ShowDialogListForm(KartTuru.Sinif, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SinifAdi;
                        }
                    }
                    break;

                case "txtYabanciDil":
                    {
                        var entity = (YabanciDil)ShowListForms<YabanciDilListForm>.ShowDialogListForm(KartTuru.YabanciDil, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.YabanciDilAdi;
                        }
                    }
                    break;

                case "txtGeldigiOkul":
                    {
                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OkulAdi;
                        }
                    }
                    break;

                case "txtKontenjanTuru":
                    {
                        var entity = (Kontenjan)ShowListForms<KontenjanListForm>.ShowDialogListForm(KartTuru.Kontenjan, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KontenjanAdi;
                        }
                    }
                    break;

                case "txtTesvikDurumu":
                    {
                        var entity = (Tesvik)ShowListForms<TesvikListForm>.ShowDialogListForm(KartTuru.Tesvik, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.TesvikAdi;
                        }
                    }
                    break;

                case "txtRehber":
                    {
                        var entity = (Rehber)ShowListForms<RehberListForm>.ShowDialogListForm(KartTuru.Rehber, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                    }
                    break;

                case "txtBankaHesap":
                    {
                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _odemeTipi);

                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.BlokeGunSayisi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HesapAdi;
                        }
                    }
                    break;

                case "txtOdemeTuru":
                    {
                        var entity = (OdemeTuru)ShowListForms<OdemeTuruListForm>.ShowDialogListForm(KartTuru.OdemeTuru, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.OdemeTipi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OdemeTuruAdi;
                        }
                    }
                    break;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}