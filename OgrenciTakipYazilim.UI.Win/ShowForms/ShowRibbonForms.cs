using System;
using DevExpress.XtraBars.Ribbon;

namespace OgrenciTakipYazilim.UI.Win.ShowForms
{
    public class ShowRibbonForms<TForm>
    where TForm : RibbonForm
    {
        public static void ShowFrom(bool dialog, params object[] prm)
        {
            TForm frm = (TForm) Activator.CreateInstance(typeof(TForm), prm);
            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }
    }
}