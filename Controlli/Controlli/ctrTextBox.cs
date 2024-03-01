using System;
using Wisej.Web;

namespace AppWeb1
{
    public partial class ctrTextBox : TextBox
    {
        public ctrTextBox()
        {
            InitializeComponent();
        }

        public string zNomeTabella { get; set; }

        public string zNomeCampo { get; set; }

    }
}
