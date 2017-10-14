using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class PurposeModel
    {
        DataTable dt = new DataTable();

        MySqlConnection mysql = new MySqlConnection(dents.Connection.credentials);
        MySqlCommand cmd = new MySqlCommand();

        public DataTable getAllPurpose()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_PROCEDURES";
            //cmd.CommandText = "SELECT * FROM procedures";
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

        public Boolean deletePurpose(int id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_DELETE_PROCEDURE_BY_ID";
            //cmd.CommandText = "DELETE FROM procedures WHERE id = @id";
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

        public Boolean updatePurpose(string id, string procedure_name, string procedure_amount)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_UPDATE_PROCEDURE";
            //cmd.CommandText = "UPDATE procedures SET procedure_name = @procedure_name, amount = @procedure_amount WHERE id = @id";
            cmd.Parameters.AddWithValue("@in_id", id);
            cmd.Parameters.AddWithValue("@in_procedure_name", procedure_name);
            cmd.Parameters.AddWithValue("@in_procedure_amount", procedure_amount);
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

        public Int32 addPurpose(string procedure_name, string procedure_amount)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_PROCEDURES";
            //cmd.CommandText = "INSERT INTO procedures(procedure_name,amount) VALUES(@procedure_name,@procedure_amount)";
            cmd.Parameters.AddWithValue("@in_procedure_name", procedure_name);
            cmd.Parameters.AddWithValue("@in_procedure_amount", procedure_amount);
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
    }
}
