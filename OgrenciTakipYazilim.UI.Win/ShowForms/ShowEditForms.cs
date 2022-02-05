using OgrenciTakipYazilim.Common.Enums;
using OgrenciTakipYazilim.UI.Win.Forms.BaseForms;
using OgrenciTakipYazilim.UI.Win.ShowForms.Interfaces;
using System;
using System.Windows.Forms;
using OgrenciTakipYazilim.Model.Entities.Base.Interfaces;

namespace OgrenciTakipYazilim.UI.Win.ShowForms
{
    public class ShowEditForms<TForm> : IBaseShowForm
        where TForm : BaseEditForm
    {
        public long ShowDialogEditFrom(KartTuru kartTuru, long id)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseEditIslemTuru = id > 0
                    ? IslemTuru.EntityUpdate
                    : IslemTuru.EntityInsert;

                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYap ? frm.Id : 0;
            }
        }

        public static long ShowDialogEditFrom(KartTuru kartTuru, long id, params object[] prm)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseEditIslemTuru = id > 0
                    ? IslemTuru.EntityUpdate
                    : IslemTuru.EntityInsert;

                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYap ? frm.Id : 0;
            }
        }

        public static bool ShowDialogEditFrom(params object[] prm)
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                return frm.DialogResult == DialogResult.OK;
            }
        }


        public static T ShowDialogEditFrom<T>(params object[] prm) where T : IBaseEntity
        {
            using (TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }
    }
}