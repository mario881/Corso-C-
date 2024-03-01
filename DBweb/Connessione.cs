using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBweb
{
    public class Connessione
    {
        public SqlConnection cn;
        public string strCo = "";

        public Connessione(string strCo)
        {
            this.strCo = strCo;
            cn = new SqlConnection(strCo);
        }

        public SqlTransaction Tr;
        public void Apri(bool Transazione = false)
        {
            cn.Open();
            if (Transazione == true)
            {
                Tr = cn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            }
            else { Tr = null; }
        }

        public void Chiudi()
        {

            if (Tr != null)
            {
                Tr.Commit();
                Tr = null;
            }
            cn.Close();

        }
    }
}
