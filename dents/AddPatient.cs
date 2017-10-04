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

            DateTime bday = DateTime.Parse(birthday_textbox.Text);

            try
            {
                string firstname = firstname_textbox.Text;
                string lastname = lastame_textbox.Text;
                string phone = phone_textbox.Text;
                string address = address_textbox.Text;
                string birthday = bday.ToString("yyyy-MM-dd");
                string gender = ((KeyValuePair<string, string>)gender_combobox.SelectedItem).Key;
                string status = ((KeyValuePair<string, string>)status_combobox.SelectedItem).Key;

                Controller.PatientController patient = new Controller.PatientController();
                int last_id = patient.addPatient(firstname, lastname, phone, address, birthday, gender, status);

                Log.addToLog("ADD PATIENT", "[ PATIENT ID: " + last_id.ToString() + " ]");

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
