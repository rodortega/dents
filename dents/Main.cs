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

            try
            {
                Controller.AppointmentController appointment = new Controller.AppointmentController();
                DataTable data = appointment.GetAllAppointments();

                ListViewItem list;
                foreach(DataRow row in data.Rows)
                {
                    string schedule = row["schedule"].ToString();
                    DateTime schedule_pretty = DateTime.Parse(schedule);

                    list = new ListViewItem(row["id"].ToString());
                    list.SubItems.Add(row["firstname"].ToString() + ' ' + row["lastname"]);
                    list.SubItems.Add(schedule_pretty.ToString("MMM dd yyyy, hh:mm tt"));
                    list.SubItems.Add(row["title"].ToString());
                    list.SubItems.Add(row["description"].ToString());
                    appointment_list.Items.Add(list);
                }

                appointment_list.EndUpdate();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Appointment Lists: \n"+ex.ToString(), "Oops!");
            }
        }

        private void load_patients()
        {
            try
            {
                Controller.PatientController patient = new Controller.PatientController();
                DataTable data = patient.getAllPatients();

                Dictionary<string, string> source = new Dictionary<string, string>();

                foreach (DataRow row in data.Rows)
                {
                    source.Add(row["id"].ToString(), row["firstname"].ToString() + " " + row["lastname"].ToString());
                }

                patients_combobox.DataSource = new BindingSource(source, null);
                patients_combobox.DisplayMember = "Value";
                patients_combobox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Patients \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_purpose()
        {
            try
            {
                Controller.PurposeController purpose = new Controller.PurposeController();
                DataTable dt = purpose.getAllPurpose();

                foreach (DataRow row in dt.Rows)
                {
                    purpose_combobox.Items.Add(row["procedure_name"].ToString());
                }
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

            try
            {
                Controller.AppointmentController appointment = new Controller.AppointmentController();
                appointment.updateAppointment(Convert.ToInt32(id_label.Text));
                    
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
            DateTime sched = DateTime.Parse(schedule_date);

            if (purpose_combobox.Text == "" || patients_combobox.Text == "")
            {
                MessageBox.Show("Patient Name and/or Purpose should not be empty", "Saving Error");
                return;
            }

            if (sched <= DateTime.Now)
            {
                MessageBox.Show("Schedule should not be earlier than today", "Saving Error");
                return;
            }

            if (patients_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an existing patient first","Saving Error");
                return;
            }

            try
            {
                string title = purpose_combobox.Text;
                string description = description_textbox.Text;
                string schedule = sched.ToString("yyyy-MM-dd HH:mm:ss");
                string patient_id = ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key;
                string status = "1";

                Controller.AppointmentController appointment = new Controller.AppointmentController();
                appointment.addAppointment(title,description,schedule,patient_id,status);

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

        private void settings_click(Object sender, EventArgs e)
        {
            this.Hide();

            Settings setting = new Settings();
            setting.Show();
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
