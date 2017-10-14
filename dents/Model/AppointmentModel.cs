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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_APPOINTMENTS";
            //cmd.CommandText = "SELECT appointments.*,  patients.firstname, patients.lastname, patients.phone, patients.address FROM appointments LEFT JOIN patients on patients.id = appointments.patient_id WHERE appointments.status = 1 ORDER BY appointments.schedule ASC";
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_SELECT_ALL_APPOINTMENTS_BY_PATIENT_ID";
            //cmd.CommandText = "SELECT * FROM appointments WHERE patient_id = @patient_id";
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

        public Boolean updateAppointment(Int32 id)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_UPDATE_APPOINTMENT";
            cmd.Parameters.AddWithValue("@in_id", id);
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

        public Boolean addAppointment(string title, string description, string schedule, string patient_id, string status)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "_INSERT_TO_APPOINTMENTS";
            //cmd.CommandText = "INSERT INTO appointments(title,description,schedule,patient_id,status) VALUES (@title,@description,@schedule,@patient_id,@status)";
            cmd.Parameters.AddWithValue("@in_title", title);
            cmd.Parameters.AddWithValue("@in_description", description);
            cmd.Parameters.AddWithValue("@in_schedule", schedule);
            cmd.Parameters.AddWithValue("@in_patient_id", patient_id);
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
