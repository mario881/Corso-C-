using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBweb
{
    public class Lock
    {
        public struct strLock
        {
            public string? Utente;
            public DateTime? dt;
            public bool? TransazioneChiusa;
            public string? Msg;
        }
        private SqlConnection _cn;
        private SqlTransaction tr;
        public Lock(string cnString)
        {
            _cn = new SqlConnection(cnString);
            _cn.Open();
            tr = _cn.BeginTransaction(IsolationLevel.ReadCommitted);
        }
        public strLock? LockRecord(string Tabella, int ID, string Utente)
        {
            //check se non è bloccato ---------------------------
            string sql = $"select * from LOCKX with(NOLOCK) where Tabella='{Tabella}' AND LockID={ID.ToString()}";
            SqlCommand cmd = new SqlCommand(sql, _cn, tr);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(dr);
            if (ta.Rows.Count > 0)
            {
                return new strLock()
                {
                    Utente = ta.Rows[0]["Utente"].ToString(),
                    dt = (DateTime?)ta.Rows[0]["Dt"],
                    Msg = $"Record in uso da {ta.Rows[0]["Utente"].ToString()} dalle ore {(DateTime?)ta.Rows[0]["Dt"]}"
                };
            }
            //---------------------------------------------------

            //Lock ----------------------------------------------
            sql = $"insert into LOCKX (Tabella, LockID, Utente,dt) VALUES ('{Tabella}', {ID.ToString()}, '{Utente}',@dt)";
            cmd = new SqlCommand(sql, _cn, tr);
            cmd.Parameters.Add("@dt", SqlDbType.DateTime).Value = DateTime.Now;

            var n = cmd.ExecuteNonQuery();
            return null;
            //---------------------------------------------------
        }

        public void UnlockRecord(string Tabella, int ID)
        {
            var sql = $"delete from LOCKX where Tabella='{Tabella}' AND LockID={ID.ToString()}";
            SqlCommand cmd = new SqlCommand(sql, _cn, tr);

            var n = cmd.ExecuteNonQuery();
        }

        public strLock? TestLockRecord(string Tabella, int ID)
        {
            string sql = $"select * from LOCKX with(NOLOCK) where Tabella='{Tabella}' AND LockID={ID.ToString()}";
            SqlCommand cmd = new SqlCommand(sql, _cn, tr);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(dr);
            if (ta.Rows.Count > 0)
            {
                return new strLock()
                {
                    Utente = ta.Rows[0]["Utente"].ToString(),
                    dt = (DateTime?)ta.Rows[0]["Dt"],
                    Msg = $"Record in uso da {ta.Rows[0]["Utente"].ToString()} dalle ore {(DateTime?)ta.Rows[0]["Dt"]}"
                };
            }
            else
            {
                return null;
            }
        }
    }
}
