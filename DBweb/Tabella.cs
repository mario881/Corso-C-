using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Wisej.Web;
using AppWeb1;
using Controlli;

namespace DBweb
{
    public class Tabella : DataTable
    {
        public int CurID = -1;
        public DataTable? taSchema;
        public Dictionary<string, object> param = new Dictionary<string, object>();

        private DBweb.Connessione? _conn;
        private string? _sql = "";
        private string _nomeTabella = "";

        public Tabella() { }

        public Tabella(Connessione conn, string sql, out Exception ex, string nomeTabella = "")
        {
            this._conn = conn;
            this._sql = sql;
            this._nomeTabella = nomeTabella;

            ex = LeggeTabella();
        }
        public Tabella(Connessione conn, string sql, Dictionary<string, object> param, out Exception ex, string nomeTabella = "")
        {
            this._conn = conn;
            this._sql = sql;
            this._nomeTabella = nomeTabella;

            foreach (var p in param)
            {
                this.param.Add(p.Key, p.Value);
            }

            ex = LeggeTabella();

        }

        private Exception? LeggeTabella()
        {
            try
            {
                using (SqlCommand cmd = _conn.cn.CreateCommand())
                {
                    cmd.CommandText = _sql;
                    cmd.Transaction = _conn.Tr;
                    foreach (var p in param)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        this.Load(dr);

                        using (SqlDataReader drSchema = cmd.ExecuteReader())
                        {
                            taSchema = drSchema.GetSchemaTable();
                        }
                    }
                }

            }
            catch (Exception ex) { return ex; }
            return null;
        }

        public int ScriviRecord()
        {
            var sql = "";

            //----- NUOVO RECORD--------------
            if ((int)this.Rows[0]["ID"] == 0)
            {
                sql = "INSERT INTO " + _nomeTabella + " (";
                foreach (DataColumn p in this.Columns)
                {
                    if (p.ColumnName != "ID" && p.DataType.Name == "String")
                    {
                        sql = sql + p.ColumnName + ", ";
                    }
                }
                sql = sql.Substring(0, sql.Length - 2);
                sql = sql + ") VALUES (";

                foreach (DataColumn p in this.Columns)
                {
                    if (p.ColumnName != "ID" && p.DataType.Name == "String")
                    {
                        sql = sql + "@" + p.ColumnName + ", ";
                    }
                }
                sql = sql.Substring(0, sql.Length - 2);
                sql = sql + ") ";
            }
            //------ AGGIORNA -----------------
            else
            {
                sql = "UPDATE " + _nomeTabella + " SET ";

                foreach (DataColumn p in this.Columns)
                {
                    if (p.ColumnName != "ID" && p.DataType.Name == "String")
                    {
                        sql = sql + p.ColumnName + "=@" + p.ColumnName + ", ";
                    }
                }

                sql = sql.Substring(0, sql.Length - 2);
                sql = sql + " WHERE ID=" + this.Rows[0]["ID"] + " ";
            }
            //------------------------------------------------------
                using (SqlCommand cmd = _conn.cn.CreateCommand())
                {
                cmd.Transaction = _conn.Tr;
                    foreach (DataColumn p in this.Columns)
                    {
                        if (p.ColumnName != "ID" && p.DataType.Name == "String") { cmd.Parameters.AddWithValue("@" + p.ColumnName, this.Rows[0][p.ColumnName].ToString()); }
                    }

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
            //-----------------------------------------------------

            return 0;
        }

        public void DaTabellaATextBox(Control ctr)
        {
            foreach (Control p in ctr.Controls)
            {
                if (p.Controls.Count > 0)
                {
                    DaTabellaATextBox(p);

                }

                switch (p.GetType().Name)
                {
                    case "ctrTextBox":
                        {
                            ctrTextBox p1 = (ctrTextBox)p;
                            p.Text = this.Rows[0][p1.zNomeCampo].ToString();
                            DataRow[] r = taSchema.Select("ColumnName='" + p1.zNomeCampo + "'");
                            p1.MaxLength = (int)r[0]["Columnsize"];
                            break;
                        }

                    case "ctrNumericBox":
                        {
                            ctrNumericBox p1 = (ctrNumericBox)p;
                            try
                            {
                            p1.zValue = (decimal)this.Rows[0][p1.zNomeCampo];
                            }catch (Exception ex) { p1.zValue = 0; }

                            break;
                        }
                }
            }
        }

        public void DaTextBoxATabella(Control ctr)
        {
            foreach (Control p in ctr.Controls)
            {
                if (p.Controls.Count > 0)
                {
                    DaTextBoxATabella(p);

                }

                switch (p.GetType().Name)
                {
                    case "ctrTextBox":
                        {
                            ctrTextBox p1 = (ctrTextBox)p;
                            this.Rows[0][p1.zNomeCampo] = p.Text;
                            break;
                        }

                    case "ctrNumericBox":
                        {
                            ctrNumericBox p1 = (ctrNumericBox)p;
                            this.Rows[0][p1.zNomeCampo] = p1.zValue;
                            break;
                        }
                }
            }


        }
    }
}
