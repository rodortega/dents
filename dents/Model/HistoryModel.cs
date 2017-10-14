using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class HistoryModel
    {
        DataTable dt = new DataTable();

        MySqlConnection mysql = new MySqlConnection(dents.Connection.credentials);
        MySqlCommand cmd = new MySqlCommand();

        public DataTable getHistoryByPatientId(int patient_id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_HISTORY_BY_PATIENT_ID";
            //cmd.CommandText = "SELECT * FROM history WHERE patient_id = @patient_id";
            cmd.Parameters.AddWithValue("@in_patient_id", patient_id);
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

        public Boolean AddHistory(string patient_id, string procedure_name, string teeth_number, string amount, string datetime_create)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_HISTORY";
            //cmd.CommandText = "INSERT INTO history(patient_id,procedure_name,teeth_number,amount,datetime_create) VALUES (@patient_id,@procedure_name,@teeth_number,@amount,@datetime_create)";
            cmd.Parameters.AddWithValue("@in_patient_id", patient_id);
            cmd.Parameters.AddWithValue("@in_procedure_name", procedure_name);
            cmd.Parameters.AddWithValue("@in_teeth_number", teeth_number);
            cmd.Parameters.AddWithValue("@in_amount", amount);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                mysql.Close();


                return true;
            }

            catch
            {
                throw;
            }
        }
    }
}
