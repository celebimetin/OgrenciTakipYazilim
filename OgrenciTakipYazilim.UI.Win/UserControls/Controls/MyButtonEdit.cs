using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OgrenciTakipYazilim.UI.Win.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

namespace OgrenciTakipYazilim.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        private long? _id;

        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }

        [Browsable(false)]
        public long? Id
        {
            get => _id;
            set
            {
                long? oldValue = _id;
                long? newValue = value;

                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue)
                {
                    return;
                }
                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                EnabledChange(this, EventArgs.Empty);
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };
        public event EventHandler EnabledChange = delegate { };

        public class IdChangedEventArgs : EventArgs
        {
            public IdChangedEventArgs(long? oldValue, long? newValue)
            {
                OldValue = oldValue;
                NewValue = newValue;
            }

            public long? OldValue { get; }
            public long? NewValue { get; }
        }
    }
}
