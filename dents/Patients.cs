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
                MessageBox.Show("Cannot Load Procedures \n" + ex.ToString(), "Oops!");
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
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM patients WHERE id = @patient_id";
            cmd.Parameters.AddWithValue("@patient_id",patient_id);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    id_textbox.Text                 = reader.GetString("id");
                    firstname_textbox.Text          = reader.GetString("firstname");
                    lastame_textbox.Text            = reader.GetString("lastname");
                    address_textbox.Text            = reader.GetString("address");
                    phone_textbox.Text              = reader.GetString("phone");
                    gender_combobox.SelectedValue   = reader.GetString("gender");
                    status_combobox.SelectedValue   = reader.GetString("status");
                    birthday_textbox.Text           = reader.GetString("birthday");
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

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM history WHERE patient_id = @patient_id";
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ListViewItem list;

                transaction_list.ListViewItemSorter = null;
                transaction_list.BeginUpdate();

                while (reader.Read())
                {
                    string datetime_create = reader.GetString("datetime_create");
                    DateTime datetime = DateTime.Parse(datetime_create);

                    list = new ListViewItem(datetime.ToString("MM/dd/yy, hh:mm tt"));
                    list.SubItems.Add(reader.GetString("teeth_number") + ":" +reader.GetString("procedure_name"));
                    list.SubItems.Add(reader.GetString("amount"));

                    transaction_list.Items.Add(list);
                }

                transaction_list.EndUpdate();
                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void load_appointment(string patient_id)
        {
            appointment_list.Items.Clear();

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM appointments WHERE patient_id = @patient_id";
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ListViewItem list;

                appointment_list.ListViewItemSorter = null;
                appointment_list.BeginUpdate();

                while (reader.Read())
                {
                    string datetime_create = reader.GetString("schedule");
                    DateTime datetime = DateTime.Parse(datetime_create);

                    list = new ListViewItem(datetime.ToString("MM/dd/yy, hh:mm tt"));
                    list.SubItems.Add(reader.GetString("title"));
                    appointment_list.Items.Add(list);
                }

                appointment_list.EndUpdate();
                mysql.Close();
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

            DateTime birthday = DateTime.Parse(birthday_textbox.Text);
            string patient_id = ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key;

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE patients SET firstname = @firstname, lastname = @lastname, phone = @phone, address = @address, birthday = @birthday, gender = @gender, status = @status WHERE id = @patient_id";
            cmd.Parameters.AddWithValue("@patient_id", patient_id);
            cmd.Parameters.AddWithValue("@firstname", firstname_textbox.Text);
            cmd.Parameters.AddWithValue("@lastname", lastame_textbox.Text);
            cmd.Parameters.AddWithValue("@phone", phone_textbox.Text);
            cmd.Parameters.AddWithValue("@address", address_textbox.Text);
            cmd.Parameters.AddWithValue("@birthday", birthday.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@gender", ((KeyValuePair<string, string>)gender_combobox.SelectedItem).Key);
            cmd.Parameters.AddWithValue("@status", ((KeyValuePair<string, string>)status_combobox.SelectedItem).Key);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

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
