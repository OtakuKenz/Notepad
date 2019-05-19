using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notepad
{
    public class VM
    {
        private int fontSize;
        public int FontSize
        {
            get { return fontSize; }
            set
            {
                if (fontSize != value)
                {
                    fontSize = value;
                    RaisePropertyChanged("FontSize");
                }
            }
        }

        private bool isOnTop;
        public bool IsOnTop
        {
            get { return isOnTop; }
            set
            {
                if (isOnTop != value)
                {
                    isOnTop = value;
                    RaisePropertyChanged("IsOnTop");
                }
            }
        }

        private bool isWrap;
        public bool IsWrap
        {
            get { return isWrap; }
            set
            {
                if (isWrap != value)
                {
                    isWrap = value;
                    RaisePropertyChanged("IsWrap");
                    Wrapping = value ? TextWrapping.Wrap : TextWrapping.NoWrap;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
