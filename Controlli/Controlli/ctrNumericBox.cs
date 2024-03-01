using AppWeb1;
using Microsoft.Ajax.Utilities;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Wisej.Web;

namespace Controlli
{
    public partial class ctrNumericBox : ctrTextBox
    {
        public ctrNumericBox()
        {
            InitializeComponent();

        }

        private Decimal _zValue;
        public Decimal zValue { 
            get
            {
                return _zValue;
            }
            set
            {
                _zValue = (decimal) value;
               this.Text = zValue.ToString("###,###,###.###");
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if(!decimal.TryParse(this.Text, out decimal n)) {
                this.Focus();
            }
            zValue = n;
            base.OnLostFocus(e);
        }



    }
}
