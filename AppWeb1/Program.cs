using System;
using Wisej.Web;

namespace AppWeb1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Desktop = new MyDesktop();

            frmLogin window = new frmLogin();
            window.ShowDialog();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}