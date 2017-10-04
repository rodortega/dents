using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class UserModel
    {
        DataTable dt = new DataTable();

        MySqlConnection mysql = new MySqlConnection(dents.Connection.credentials);
        MySqlCommand cmd = new MySqlCommand();

        public DataTable getUserByCredential(string username, string password)
        {
            cmd.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                mysql.Close();

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public DataTable getUserById(int id)
        {
            cmd.CommandText = "SELECT * FROM users WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                mysql.Close();

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public DataTable getOtherUsers()
        {
            cmd.CommandText = "SELECT id, username, firstname, lastname FROM users WHERE id != 1";
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                mysql.Close();

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public Boolean deleteUser(int id)
        {
            cmd.CommandText = "DELETE FROM users WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
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

        public Int32 addUser(string username, string password, string firstname, string lastname)
        {
            cmd.CommandText = "INSERT INTO users(username, password, firstname, lastname) VALUES(@username, @password, @firstname, @lastname)";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                return Convert.ToInt32(cmd.LastInsertedId);
            }

            catch
            {
                throw;
            }
        }

        public Boolean updateUser(string id, string username, string firstname, string lastname)
        {
            cmd.CommandText = "UPDATE users SET username = @username, firstname = @firstname, lastname = @lastname WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
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

        public Boolean changePassword(string id, string password)
        {
            cmd.CommandText = "UPDATE users SET password = @password WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);
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
