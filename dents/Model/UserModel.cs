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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_USERS_BY_USERNAME_AND_PASSWORD";
            //cmd.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@in_username", username);
            cmd.Parameters.AddWithValue("@in_password", password);
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_USERS_BY_ID";
            //cmd.CommandText = "SELECT * FROM users WHERE id = @id";
            cmd.Parameters.AddWithValue("@in_id", id);
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_USERS_NOT_ADMIN";
            //cmd.CommandText = "SELECT id, username, firstname, lastname FROM users WHERE id != 1";
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_DELETE_USER_BY_ID";
            //cmd.CommandText = "DELETE FROM users WHERE id = @id";
            cmd.Parameters.AddWithValue("@in_id", id);
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_USERS";
            //cmd.CommandText = "INSERT INTO users(username, password, firstname, lastname) VALUES(@username, @password, @firstname, @lastname)";
            cmd.Parameters.AddWithValue("@in_username", username);
            cmd.Parameters.AddWithValue("@in_password", password);
            cmd.Parameters.AddWithValue("@in_firstname", firstname);
            cmd.Parameters.AddWithValue("@in_lastname", lastname);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string last_insert_id = reader.GetString("id").ToString();
                mysql.Close();
                return Convert.ToInt32(last_insert_id);
            }

            catch
            {
                throw;
            }
        }

        public Boolean updateUser(string id, string username, string firstname, string lastname)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_UPDATE_USER";
            //cmd.CommandText = "UPDATE users SET username = @username, firstname = @firstname, lastname = @lastname WHERE id = @id";
            cmd.Parameters.AddWithValue("@in_id", id);
            cmd.Parameters.AddWithValue("@in_username", username);
            cmd.Parameters.AddWithValue("@in_firstname", firstname);
            cmd.Parameters.AddWithValue("@in_lastname", lastname);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                return true;
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public Boolean changePassword(string id, string password)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_UPDATE_USER_ONLY_PASSWORD";
            //cmd.CommandText = "UPDATE users SET password = @password WHERE id = @id";
            cmd.Parameters.AddWithValue("@in_id", id);
            cmd.Parameters.AddWithValue("@in_password", password);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
