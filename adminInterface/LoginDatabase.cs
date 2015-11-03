using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace adminInterface
{
    class LoginDatabase
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

        public void TengingVidLoginGagnagrunn()
        {
            server = "tsuts.tskoli.is";
            database = "0105982499_admininterface";
            uid = "0105982499";
            password = "mypassword";

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }
        private bool OpenConnectionLogin()
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
        private bool CloseConnectionLogin()
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
        public bool Login(string username, string password)
        {
            OpenConnectionLogin();
            MySqlCommand nySQLskipun = new MySqlCommand();
            nySQLskipun.CommandText = "Select * from user where username='" + username + "' and password='" + password + "'";
            nySQLskipun.Connection = sqltenging;
            MySqlDataReader sqlLesari = nySQLskipun.ExecuteReader();
            if (sqlLesari.Read())
            {
                sqltenging.Close();
                return true;
            }
            else
            {
                sqltenging.Close();
                return false;
            }
        }
        public void Register(string username, string password)
        {
            if (OpenConnectionLogin() == true)
            {
                fyrirspurn = "INSERT INTO user (username, password, adminpower) VALUES ('" + username + "', '" + password + "', 3)";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnectionLogin();
            }
        }
    }
}
