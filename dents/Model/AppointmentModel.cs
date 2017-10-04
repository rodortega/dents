using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class AppointmentModel
    {

        DataTable dt = new DataTable();

        MySqlConnection mysql = new MySqlConnection(dents.Connection.credentials);
        MySqlCommand cmd = new MySqlCommand();

        public DataTable getAllAppointments()
        {
            cmd.CommandText = "SELECT appointments.*,  patients.firstname, patients.lastname, patients.phone, patients.address FROM appointments LEFT JOIN patients on patients.id = appointments.patient_id WHERE appointments.status = 1 ORDER BY appointments.schedule ASC";
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

        public DataTable getAppointmentByPatientId(Int32 patient_id)
        {
            cmd.CommandText = "SELECT * FROM appointments WHERE patient_id = @patient_id";
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
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

        public Boolean updateAppointment(Int32 id)
        {
            cmd.CommandText = "UPDATE appointments SET status = 0 WHERE id = @id";
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

        public Boolean addAppointment(string title, string description, string schedule, string patient_id, string status)
        {
            cmd.CommandText = "INSERT INTO appointments(title,description,schedule,patient_id,status) VALUES (@title,@description,@schedule,@patient_id,@status)";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@schedule", schedule);
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            cmd.Parameters.AddWithValue("@status", status);
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
