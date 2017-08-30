using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MySql.Data.MySqlClient;

namespace dents
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            panel1.Hide();
            load_appointment();
            load_patients();
            load_purpose();
            reset_appointment();
        }

        private void load_appointment()
        {
            appointment_list.Items.Clear();

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT appointments.*,  patients.firstname, patients.lastname, patients.phone, patients.address FROM appointments LEFT JOIN patients on patients.id = appointments.patient_id WHERE appointments.status = 1 ORDER BY appointments.schedule ASC";
            cmd.Connection = mysql;

            // make listview faster by BeginUpdate() then EndUpdate() after
            appointment_list.ListViewItemSorter = null;
            appointment_list.BeginUpdate();

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                ListViewItem list;

                while (reader.Read())
                {
                    // format datetime to pretty format
                    string schedule = reader.GetString("schedule");
                    DateTime schedule_pretty = DateTime.Parse(schedule);
                    // add everything from DB to listview
                    list = new ListViewItem(reader.GetString("id"));
                    list.SubItems.Add(reader.GetString("firstname") + ' ' + reader.GetString("lastname"));
                    list.SubItems.Add(schedule_pretty.ToString("MMM dd yyyy, hh:mm tt"));
                    list.SubItems.Add(reader.GetString("title"));
                    list.SubItems.Add(reader.GetString("description"));
                    appointment_list.Items.Add(list);
                    
                }
                // EndUpdate triggers the drawing of the listview
                appointment_list.EndUpdate();
                mysql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Appointment Lists: \n"+ex.ToString(), "Oops!");
            }
        }

        private void load_patients()
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT id, firstname, lastname FROM patients";
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> source = new Dictionary<string, string>();

                while (reader.Read())
                {
                    source.Add(reader.GetString("id"), reader.GetString("firstname") + " " + reader.GetString("lastname"));
                }

                patients_combobox.DataSource = new BindingSource(source, null);
                patients_combobox.DisplayMember = "Value";
                patients_combobox.ValueMember = "Key";

                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Patients \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_purpose()
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT procedure_name FROM procedures";
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    purpose_combobox.Items.Add(reader.GetString("procedure_name"));
                }

                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Procedures \n" + ex.ToString(), "Oops!");
            }
        }

        private void reset_appointment()
        {
            purpose_combobox.SelectedIndex = -1;
            patients_combobox.SelectedIndex = -1;
            description_textbox.Text = "";
            schedule_textbox.Text = DateTime.Now.ToString();
        }

        private void appointment_list_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (appointment_list.SelectedItems.Count == 0)
            {
                return;
            }
            panel1.Show();

            ListViewItem item = appointment_list.SelectedItems[0];

            id_label.Text           = item.Text;
            patient_label.Text      = item.SubItems[1].Text;
            date_time_label.Text    = item.SubItems[2].Text;
            purpose_label.Text      = item.SubItems[3].Text;
            description_label.Text  = item.SubItems[4].Text;
        }

        private void acknowledge_click(Object sender, EventArgs e)
        {
            if (appointment_list.SelectedItems.Count == 0)
            {
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE appointments SET status = 0 WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id_label.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                appointment_list.SelectedItems[0].Remove();

                Log.addToLog("ACKNOWLEDGE APPOINTMENT","[ ACK ID: "+id_label.Text+" ][ PATIENT ID: "+ id_label.Text + " ]");

                MessageBox.Show("Appointment Acknowledged.", "Success");
                panel1.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Patients \n" + ex.ToString(), "Oops!");
            }
        }

        private void refresh_click(Object sender, EventArgs e)
        {
            panel1.Hide();
            load_appointment();
        }

        private void save_click(Object sender, EventArgs e)
        {
            string schedule_date = schedule_textbox.Text;
            DateTime schedule = DateTime.Parse(schedule_date);

            if (purpose_combobox.Text == "" || patients_combobox.Text == "")
            {
                MessageBox.Show("Patient Name and/or Purpose should not be empty", "Saving Error");
                return;
            }

            if (schedule <= DateTime.Now)
            {
                MessageBox.Show("Schedule should not be earlier than today", "Saving Error");
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO appointments(title,description,schedule,patient_id,status) VALUES (@title,@description,@schedule,@patient_id,@status)";
            cmd.Parameters.AddWithValue("@title", purpose_combobox.Text);
            cmd.Parameters.AddWithValue("@description", description_textbox.Text);
            cmd.Parameters.AddWithValue("@schedule", schedule.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@patient_id", ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key);
            cmd.Parameters.AddWithValue("@status", "1");
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                Log.addToLog("ADD APPOINTMENT", "[ PATIENT ID: " + ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key + " ]");

                MessageBox.Show("Appointment successfully Added!", "Successful");
                reset_appointment();
                load_appointment();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: \n" +ex.ToString(),"Oops!");
            }                        
        }

        private void transaction_click(Object sender, EventArgs e)
        {
            this.Hide();

            AddTransaction addtransaction = new AddTransaction();
            addtransaction.Show();
        }

        private void patients_click(Object sender, EventArgs e)
        {
            this.Hide();

            Patients patient = new Patients();
            patient.Show();
        }

        private void logs_click(Object sender, EventArgs e)
        {
            this.Hide();

            Logs logs = new Logs();
            logs.Show();
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
