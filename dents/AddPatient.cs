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
    public partial class AddPatient : MaterialForm
    {
        public AddPatient()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            load_gender();
            load_status();
        }

        private void load_gender()
        {
            Dictionary<string, string> source = new Dictionary<string, string>();

            source.Add("m", "Male");
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

        private void save_click(Object sender, EventArgs e)
        {
            if (firstname_textbox.Text == "" || lastame_textbox.Text == "" || phone_textbox.Text == "" || address_textbox.Text == "")
            {
                MessageBox.Show("All fields should not be empty", "Saving Error");
                return;
            }

            DateTime birthday = DateTime.Parse(birthday_textbox.Text);

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO patients (firstname, lastname, phone, address, birthday, gender, status) VALUES (@firstname, @lastname, @phone, @address, @birthday, @gender, @status)";
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

                Log.addToLog("ADD PATIENT", "[ PATIENT ID: " + cmd.LastInsertedId.ToString() + " ]");

                MessageBox.Show("Profile update successful", "Successful");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
        }
    }
}
