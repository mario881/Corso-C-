using System;
using Wisej.Web;
using System.Collections.Generic;

namespace AppWeb1
{
    public partial class frmLogin : Form
    {
        DBweb.Connessione cn = new DBweb.Connessione("Server=PCMARIO\\SQLEXPRESS; Database=GestioneSqlServer; Trusted_Connection=True;");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            var sql = "Select * From Utenti where Utente=@Utente AND Password=@Password";
            DBweb.Tabella utenti = new DBweb.Tabella(cn, sql, new Dictionary<string, object>
            {
                {"@Utente", txtUtente.Text },
                {"@Password",txtPassword.Text }
            },
            out Exception ex
            );

            if(utenti.Rows.Count == 0) {
                MessageBox.Show("Utente o password errati");
            } else
            {
              clsSessione clsSessione = new clsSessione();
              clsSessione.Utente = txtUtente.Text;
              clsSessione.Autenticato = true;    
              Application.Session.clsSessione=clsSessione;

                cn.Chiudi();
                this.Close();
            }



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cn.Apri();
#if DEBUG
            txtUtente.Text = "pippo";
            txtPassword.Text = "topolino";
            btnConferma_Click(null, null);
#endif
        }
    }
}
