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
    public partial class Patients : MaterialForm
    {
        public Patients()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            panel1.Hide();

            load_patient();
            load_gender();
            load_status();
            toggle_profile(false);
        }

        private void load_gender()
        {
            Dictionary<string, string> source = new Dictionary<string, string>();

            source.Add("m","Male");
            source.Add("f", "Female");

            gender_combobox.DataSource = new BindingSource(source, null);
            gender_combobox.DisplayMember = "Value";
            gender_combobox.ValueMember = "Key";
        }

        private void load_status()
        {
            Dictionary<string, string> source = new Dictionary<string, string>();

            source.Add("1", "Active");
            source.Add("0", "Disabled");

            status_combobox.DataSource = new BindingSource(source, null);
            status_combobox.DisplayMember = "Value";
            status_combobox.ValueMember = "Key";
        }

        private void load_patient()
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

        private void toggle_profile(bool status)
        {
            if (status == false)
            {
                firstname_textbox.Enabled = false;
                lastame_textbox.Enabled = false;
                address_textbox.Enabled = false;
                phone_textbox.Enabled = false;
                birthday_textbox.Enabled = false;
                gender_combobox.Enabled = false;
                status_combobox.Enabled = false;
            }
            else
            {
                firstname_textbox.Enabled = true;
                lastame_textbox.Enabled = true;
                address_textbox.Enabled = true;
                phone_textbox.Enabled = true;
                birthday_textbox.Enabled = true;
                gender_combobox.Enabled = true;
                status_combobox.Enabled = true;
            }

        }

        private void view_click(Object sender, EventArgs e)
        {
            if (patients_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an existing Patient","View Error");
                return;
            }

            string patient_id = ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key;

            load_profile(patient_id);
            load_appointment(patient_id);
            load_transaction(patient_id);
        }

        private void load_profile(string patient_id)
        {
            try
            {
                Controller.PatientController patient = new Controller.PatientController();
                DataTable data = patient.getPatientById(Convert.ToInt32(patient_id));

                foreach(DataRow row in data.Rows)
                {
                    id_textbox.Text                 = row["id"].ToString();
                    firstname_textbox.Text          = row["firstname"].ToString();
                    lastame_textbox.Text            = row["lastname"].ToString();
                    address_textbox.Text            = row["address"].ToString();
                    phone_textbox.Text              = row["phone"].ToString();
                    gender_combobox.SelectedValue   = row["gender"].ToString();
                    status_combobox.SelectedValue   = row["status"].ToString();
                    birthday_textbox.Text           = row["birthday"].ToString();
                }
                panel1.Show();
                toggle_profile(false);

                edit_button.Visible = true;
                save_button.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void load_transaction(string patient_id)
        {
            transaction_list.Items.Clear();

            try
            {
                Controller.HistoryController history = new Controller.HistoryController();
                DataTable data = history.getHistoryByPatientId(Convert.ToInt32(patient_id));

                ListViewItem list;

                transaction_list.ListViewItemSorter = null;
                transaction_list.BeginUpdate();

                foreach(DataRow row in data.Rows)
                {
                    string datetime_create = row["datetime_create"].ToString();
                    DateTime datetime = DateTime.Parse(datetime_create);

                    list = new ListViewItem(datetime.ToString("MM/dd/yy, hh:mm tt"));
                    list.SubItems.Add(row["teeth_number"].ToString() + ":" + row["procedure_name"].ToString());
                    list.SubItems.Add(row["amount"].ToString());

                    transaction_list.Items.Add(list);
                }

                transaction_list.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void load_appointment(string patient_id)
        {
            appointment_list.Items.Clear();

            try
            {
                Controller.AppointmentController appointment = new Controller.AppointmentController();
                DataTable data = appointment.getAppointmentByPatientId(Convert.ToInt32(patient_id));

                ListViewItem list;

                appointment_list.ListViewItemSorter = null;
                appointment_list.BeginUpdate();

                foreach(DataRow row in data.Rows)
                {
                    string datetime_create = row["schedule"].ToString();
                    DateTime datetime = DateTime.Parse(datetime_create);

                    list = new ListViewItem(datetime.ToString("MM/dd/yy, hh:mm tt"));
                    list.SubItems.Add(row["title"].ToString());
                    appointment_list.Items.Add(list);
                }

                appointment_list.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void edit_click(Object sender, EventArgs e)
        {
            toggle_profile(true);
            edit_button.Visible = false;
            save_button.Visible = true;
        }

        private void save_click(Object sender, EventArgs e)
        {
            if (firstname_textbox.Text == "" || lastame_textbox.Text == "" || phone_textbox.Text == "" || address_textbox.Text == "")
            {
                MessageBox.Show("All fields should not be empty", "Saving Error");
                return;
            }

            DateTime bday = DateTime.Parse(birthday_textbox.Text);
            
            try
            {
                string patient_id = ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key;
                string firstname = firstname_textbox.Text;
                string lastname = lastame_textbox.Text;
                string phone = phone_textbox.Text;
                string address = address_textbox.Text;
                string birthday = bday.ToString("yyyy-MM-dd");
                string gender = ((KeyValuePair<string, string>)gender_combobox.SelectedItem).Key;
                string status = ((KeyValuePair<string, string>)status_combobox.SelectedItem).Key;

                Controller.PatientController patient = new Controller.PatientController();
                patient.updatePatient(patient_id, firstname, lastname, phone, address, birthday, gender, status);

                Log.addToLog("UPDATE PATIENT", "[ PATIENT ID: " + patient_id + " ]");

                MessageBox.Show("Profile Update Successful","Successful");
                load_patient();
                patients_combobox.SelectedValue = patient_id;

                toggle_profile(false);
                edit_button.Visible = true;
                save_button.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addpatient_click(Object sender, EventArgs e)
        {
            AddPatient addpatient = new AddPatient();
            addpatient.Show();

            this.Hide();
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
