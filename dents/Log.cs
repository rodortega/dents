using System;
using System.Data;
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

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_LOGS";
            // cmd.CommandText = "INSERT INTO logs(title,description,user_id,datetime_create) VALUES(@title,@description,@user,@datetime_create)";
            cmd.Parameters.AddWithValue("@in_title", title);
            cmd.Parameters.AddWithValue("@in_description", description);
            cmd.Parameters.AddWithValue("@in_user_id", User.id);
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
