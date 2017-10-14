using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class PatientModel
    {
        DataTable dt = new DataTable();

        MySqlConnection mysql = new MySqlConnection(dents.Connection.credentials);
        MySqlCommand cmd = new MySqlCommand();

        public DataTable getAllPatients()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_PATIENTS";
            //cmd.CommandText = "SELECT id, firstname, lastname FROM patients";
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

        public DataTable getPatientById(int id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_PATIENTS_BY_ID";
            //cmd.CommandText = "SELECT * FROM patients WHERE id = @patient_id";
            cmd.Parameters.AddWithValue("@in_patient_id", id);
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

        public Int32 addPatient(string firstname, string lastname, string phone, string address, string birthday, string gender, string status)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_PATIENTS";
            //cmd.CommandText = "INSERT INTO patients (firstname, lastname, phone, address, birthday, gender, status) VALUES (@firstname, @lastname, @phone, @address, @birthday, @gender, @status)";
            cmd.Parameters.AddWithValue("@in_firstname", firstname);
            cmd.Parameters.AddWithValue("@in_lastname", lastname);
            cmd.Parameters.AddWithValue("@in_phone", phone);
            cmd.Parameters.AddWithValue("@in_address", address);
            cmd.Parameters.AddWithValue("@in_birthday", birthday);
            cmd.Parameters.AddWithValue("@in_gender", gender);
            cmd.Parameters.AddWithValue("@in_status", status);
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

        public Boolean updatePatient(string patient_id, string firstname, string lastname, string phone, string address, string birthday, string gender, string status)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_UPDATE_PATIENT";
            //cmd.CommandText = "UPDATE patients SET firstname = @firstname, lastname = @lastname, phone = @phone, address = @address, birthday = @birthday, gender = @gender, status = @status WHERE id = @patient_id";
            cmd.Parameters.AddWithValue("@in_patient_id", patient_id);
            cmd.Parameters.AddWithValue("@in_firstname", firstname);
            cmd.Parameters.AddWithValue("@in_lastname", lastname);
            cmd.Parameters.AddWithValue("@in_phone", phone);
            cmd.Parameters.AddWithValue("@in_address", address);
            cmd.Parameters.AddWithValue("@in_birthday", birthday);
            cmd.Parameters.AddWithValue("@in_gender", gender);
            cmd.Parameters.AddWithValue("@in_status", status);
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
