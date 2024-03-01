using System;
using Wisej.Web;

namespace AppWeb1
{
    public partial class MyDesktop : Desktop
    {
        public MyDesktop()
        {
            InitializeComponent();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void menuClienti_Click(object sender, EventArgs e)
        {
            var frm=new frmClienti();
            frm.Show();
        }
    }
}
