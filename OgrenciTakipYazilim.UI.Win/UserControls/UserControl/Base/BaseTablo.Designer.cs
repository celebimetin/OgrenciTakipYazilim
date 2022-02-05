﻿namespace OgrenciTakipYazilim.UI.Win.UserControls.UserControl.Base
{
    partial class BaseTablo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.insUptNavigator = new OgrenciTakipYazilim.UI.Win.UserControls.Navigators.InsUptNavigator();
            this.sagPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnHareketEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKartDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnIptalEt = new DevExpress.XtraBars.BarButtonItem();
            this.btnIptalGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnBelgeHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.sagPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insUptNavigator.Location = new System.Drawing.Point(0, 397);
            this.insUptNavigator.MinimumSize = new System.Drawing.Size(438, 24);
            this.insUptNavigator.Name = "insUptNavigator";
            this.insUptNavigator.Size = new System.Drawing.Size(700, 24);
            this.insUptNavigator.TabIndex = 0;
            // 
            // sagPopupMenu
            // 
            this.sagPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKartDuzenle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHareketSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIptalEt),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIptalGeriAl),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBelgeHareketleri)});
            this.sagPopupMenu.Manager = this.barManager;
            this.sagPopupMenu.Name = "sagPopupMenu";
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Caption = "Hareket Ekle";
            this.btnHareketEkle.Id = 0;
            this.btnHareketEkle.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.insert_16x16;
            this.btnHareketEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnHareketEkle.Name = "btnHareketEkle";
            // 
            // btnKartDuzenle
            // 
            this.btnKartDuzenle.Caption = "Kart Düzenle";
            this.btnKartDuzenle.Id = 2;
            this.btnKartDuzenle.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.edit_16x161;
            this.btnKartDuzenle.ImageOptions.LargeImage = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.edit_32x321;
            this.btnKartDuzenle.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnKartDuzenle.Name = "btnKartDuzenle";
            this.btnKartDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.Caption = "Hareket Sil";
            this.btnHareketSil.Id = 1;
            this.btnHareketSil.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.close_16x16;
            this.btnHareketSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.btnHareketSil.Name = "btnHareketSil";
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Caption = "İptal Et";
            this.btnIptalEt.Id = 3;
            this.btnIptalEt.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.removeitem_16x16;
            this.btnIptalEt.ImageOptions.LargeImage = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.removeitem_32x32;
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.ShortcutKeyDisplayString = "Ctrl+T";
            this.btnIptalEt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnIptalGeriAl
            // 
            this.btnIptalGeriAl.Caption = "İptal Geri Al";
            this.btnIptalGeriAl.Id = 4;
            this.btnIptalGeriAl.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.reset_16x161;
            this.btnIptalGeriAl.ImageOptions.LargeImage = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.reset_32x321;
            this.btnIptalGeriAl.Name = "btnIptalGeriAl";
            this.btnIptalGeriAl.ShortcutKeyDisplayString = "Ctrl+R";
            this.btnIptalGeriAl.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnBelgeHareketleri
            // 
            this.btnBelgeHareketleri.Caption = "Belge Hareketleri";
            this.btnBelgeHareketleri.Id = 5;
            this.btnBelgeHareketleri.ImageOptions.Image = global::OgrenciTakipYazilim.UI.Win.Properties.Resources.documentmap_16x16;
            this.btnBelgeHareketleri.Name = "btnBelgeHareketleri";
            this.btnBelgeHareketleri.ShortcutKeyDisplayString = "F4";
            this.btnBelgeHareketleri.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHareketEkle,
            this.btnHareketSil,
            this.btnKartDuzenle,
            this.btnIptalEt,
            this.btnIptalGeriAl,
            this.btnBelgeHareketleri});
            this.barManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // BaseTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insUptNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTablo";
            this.Size = new System.Drawing.Size(700, 421);
            ((System.ComponentModel.ISupportInitialize)(this.sagPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.PopupMenu sagPopupMenu;
        private DevExpress.XtraBars.BarButtonItem btnHareketEkle;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem btnKartDuzenle;
        protected DevExpress.XtraBars.BarButtonItem btnIptalGeriAl;
        protected DevExpress.XtraBars.BarButtonItem btnIptalEt;
        protected DevExpress.XtraBars.BarButtonItem btnHareketSil;
        protected DevExpress.XtraBars.BarButtonItem btnBelgeHareketleri;
        protected internal Navigators.InsUptNavigator insUptNavigator;
    }
}
