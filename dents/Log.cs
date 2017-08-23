using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dents
{
    public static class Log
    {
        public static bool addToLog(string title, string description)
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO logs(title,description,user,datetime_create) VALUES(@title,@description,@user,@datetime_create)";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@user", User.fullname);
            cmd.Parameters.AddWithValue("@datetime_create", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
