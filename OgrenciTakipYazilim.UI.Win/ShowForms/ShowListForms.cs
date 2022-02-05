using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.Model.Entities.Base;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;
using OgrenciTakipYazilim.UI.Win.Functions;

namespace OgrenciTakipYazilim.UI.Win.ShowForms
{
    public class ShowListForms<TForm>
        where TForm : BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            TForm frm = (TForm)Activator.CreateInstance(typeof(TForm));

            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK
                    ? frm.SelectedEntity
                    : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru,
            IList<long> listeDisiTutulacakKayitler, bool multiSelect, params object[] prm)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitler;
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.MultiSelect = multiSelect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}
