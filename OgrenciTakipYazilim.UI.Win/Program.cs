using OgrenciTakipYazilim.UI.Win.GenelForms;
using System;
using System.Windows.Forms;

namespace OgrenciTakipYazilim.UI.Win
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
