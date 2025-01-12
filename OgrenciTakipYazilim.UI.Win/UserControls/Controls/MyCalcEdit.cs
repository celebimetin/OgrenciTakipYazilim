﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using OgrenciTakipYazilim.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakipYazilim.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit, IStatusBarKisaYol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.DisplayFormat.FormatType = FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";
            Properties.EditMask = "n2";
            
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinası";
        public string StatusBarAciklama { get; set; }
    }
}
