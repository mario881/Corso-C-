using System;
using Wisej.Web;
using DBweb;
using System.Collections.Generic;
using System.Data;

namespace AppWeb1
{
    public partial class frmClienti : Form
    {
        Connessione cn =  new Connessione(Application.Configuration.Settings.ConnectionString);
        Tabella taInte;
        string NomeTa = "Clienti";

        public frmClienti()
        {
            InitializeComponent();
        }

        clsSessione sessione = Application.Session.clsSessione;
        private void frmGenerico_Load(object sender, EventArgs e)
        {
            
            Init();
        }

        private void Init()
        {
            cn.Apri(true);

            Tabella ta = new Tabella(cn, $"select TOP 100 * from {NomeTa} order by ID desc", out Exception ex);
            grRicerca.DataSource = ta;
            tabControl1.TabPages["tabPage2"].Hidden = true;

            foreach (DataColumn c in ta.Columns)
            {
                if (c.DataType.Name.ToString() == "String")
                {
                    cmbCampiRicerca.Items.Add(c.ToString());
                }
            }
            cmbCampiRicerca.SelectedText = "RagSoc";
        }
        private void btnFiltra_Click(object sender, EventArgs e)
        {
            Tabella ta = new Tabella(cn, $"select TOP 100 * from {NomeTa} WHERE {cmbCampiRicerca.SelectedText} like'%{txtValoreFiltra.Text}%' order by {cmbCampiRicerca.SelectedText}", out Exception ex);
            grRicerca.DataSource = ta;
        }

        private void grRicerca_DoubleClick(object sender, EventArgs e)
        {
            Apri();
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            Apri();
        }

        private Lock lo;
        private int curID = -1;
        private void Apri()
        {
            lo = new Lock(cn.strCo);

            var x = grRicerca.SelectedRows[0]["ID"].Value;
            curID = (int)x;

            //Test lock
            Lock.strLock? r = lo.TestLockRecord(NomeTa, curID);
            if(r!= null)
            {
                MessageBox.Show(r.Value.Msg);
                cn.Chiudi();
                Init();
                return;
            }
            //lock record
            r=lo.LockRecord(NomeTa, curID, sessione.Utente);
            
            taInte = new Tabella(cn, $"select * from {NomeTa} where ID=@ID", new Dictionary<string, object> { { "@ID", curID } }, out Exception ex,NomeTa);
            if(taInte.Rows.Count == 0) { MessageBox.Show("Nessun cliente selezionato"); }

            CaricaDati();

        }

        private void CaricaDati()
        {
            taInte.DaTabellaATextBox(tabControl1);

            tabControl1.SelectedTab = tabPage2;
         }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            taInte.DaTextBoxATabella(tabControl1);
            taInte.ScriviRecord();
            tabControl1.SelectedTab= tabPage1;
            tabControl1.TabPages["tabPage2"].Hidden = true;

            cn.Chiudi();

            //Unlock Record
            lo.UnlockRecord(NomeTa, curID);
            Init();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            taInte = new Tabella(cn, $"select * from {NomeTa} where 1=2", new Dictionary<string, object>(), out Exception ex, NomeTa);
            taInte.Rows.Add(taInte.NewRow());
            CaricaDati();
        }


    }
}
