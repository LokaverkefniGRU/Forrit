using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace adminInterface
{
    class DatabaseMain
    {
        private string server;
        private string database;
        private string uid;
        private string password;

        string tengistrengur = null;
        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqllesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "tsuts.tskoli.is";
            database = "0712982139_gru";
            uid = "0712982139";
            password = "banana555";

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }
        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                sqltenging.Close();
                throw ex;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                sqltenging.Close();
                throw ex;
            }
        }
        public List<string> Show()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT id, username, fullname, email, confirmed, change_password, report_status FROM user";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        public void Update(string id, string username, string fullname, string email, string confirmed, string changepassword, string reportstatus)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE user SET username='" + username + "', fullname='" + fullname + "', email='" + email + "', confirmed='" + confirmed + "', change_password='" + changepassword + "', report_status='" + reportstatus + "' WHERE id='" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public List<string> Search(string search)
        {
            List<string> Results = new List<string>();
            string Row = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT id, username, fullname, email, confirmed, change_password, report_status FROM user WHERE id LIKE '%" + search + "%' OR username LIKE '%" + search + "%' OR fullname LIKE '%" + search + "%' OR email LIKE '%" + search + "%'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        Row += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    Results.Add(Row);
                    Row = null;
                }
                CloseConnection();
                return Results;
            }
            return Results;
        }
        public void Delete(string id, string username, string fullname, string email)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "DELETE FROM user WHERE id='" + id + "' AND username='" + username + "' AND fullname='" + fullname + "' AND email='" + email + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public List<int> UserCount()
        {
            List<int> Results = new List<int>();
            int Row = 0;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT COUNT(id) FROM user";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        Row = Row + Convert.ToInt32(sqllesari.GetValue(i));
                    }
                    Results.Add(Row);
                    Row = 0;
                }
                CloseConnection();
                return Results;
            }
            return Results;
        }
        public List<string> AllEmailAddresses()
        {
            List<string> Results = new List<string>();
            string Row = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT email FROM user";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        Row += (sqllesari.GetValue(i).ToString()) + "";
                    }
                    Results.Add(Row);
                    Row = null;
                }
                CloseConnection();
                return Results;
            }
            return Results;
            
        }
    }
}
