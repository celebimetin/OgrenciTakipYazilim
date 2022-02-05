using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using OgrenciTakipYazilim.Common.Messages;
using OgrenciTakipYazilim.UI.Win.UserControls.Controls;

namespace OgrenciTakipYazilim.UI.Win.Functions
{
    public static class SelectPictureFunctions
    {
        private static MyPictureEdit _pictureEdit;
        private static PopupMenu _popupMenu;

        private static void RemoveEvents()
        {
            if (_pictureEdit == null)
            {
                return;
            }
            _pictureEdit.KeyDown -= PictureEdit_KeyDown;
            _pictureEdit.DoubleClick -= PictureEdit_DoubleClick;
            _pictureEdit.MouseUp -= PictureEdit_MouseUp;
            _popupMenu.Popup -= PopupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick -= Buttons_ItemClick;
            }
        }

        public static void Sec(this MyPictureEdit pictureEdit, PopupMenu popupMenu)
        {
            RemoveEvents();

            _pictureEdit = pictureEdit;
            _popupMenu = popupMenu;

            _pictureEdit.KeyDown += PictureEdit_KeyDown;
            _pictureEdit.DoubleClick += PictureEdit_DoubleClick;
            _pictureEdit.MouseUp += PictureEdit_MouseUp;
            _popupMenu.Popup += PopupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick += Buttons_ItemClick;
            }
        }

        private static void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == _popupMenu.ItemLinks[0].Item)
            {
                ResimSec();
            }
            else if(e.Item == _popupMenu.ItemLinks[1].Item)
            {
                ResimSil();
            }
        }

        private static void PopupMenu_Popup(object sender, EventArgs e)
        {
            _popupMenu.ItemLinks[1].Item.Enabled = _pictureEdit.Image != null;
        }

        private static void PictureEdit_MouseUp(object sender, MouseEventArgs e)
        {
            e.ShowPopupMenu(_popupMenu);
        }

        private static void PictureEdit_DoubleClick(object sender, EventArgs e)
        {
            ResimSec();
        }

        private static void PictureEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ResimSil();
                    break;
                case Keys.Insert:
                case Keys.F4:
                case Keys.Down when e.Modifiers == Keys.Alt:
                    ResimSec();
                    break;
            }
        }

        private static void ResimSec()
        {
            var resim = GeneralFunctionsWin.ResimYukle();
            if (resim == null)
            {
                return;
            }
            _pictureEdit.EditValue = resim;
        }

        private static void ResimSil()
        {
            if (_pictureEdit.Image == null)
            {
                return;
            }
            if (Messages.SilMesaj("Resim") != DialogResult.Yes)
            {
                return;
            }
            _pictureEdit.EditValue = null;
        }
    }
}