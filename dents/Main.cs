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
    public partial class username : MaterialForm
    {
        public username()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            panel1.Hide();
            load_appointment();
        }

        private void load_appointment()
        {
            Connection connect = new Connection();
            MySqlConnection mysql = new MySqlConnection(connect.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT appointments.*, patients.firstname, patients.lastname, patients.phone, patients.address FROM appointments LEFT JOIN patients on patients.id = appointments.patient_id ORDER BY appointments.schedule DESC";
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

                    list = new ListViewItem(reader.GetString("id"));
                    list.SubItems.Add(reader.GetString("firstname") + ' ' + reader.GetString("lastname"));
                    list.SubItems.Add(schedule_pretty.ToString("MMM dd yyyy, HH:mm tt"));
                    list.SubItems.Add(reader.GetString("title"));
                    list.SubItems.Add(reader.GetString("description"));
                    appointment_list.Items.Add(list);
                }
                // EndUpdate triggers the drawing of the listview
                appointment_list.EndUpdate();
                mysql.Close();
            }

            catch
            {
                MessageBox.Show("Cannot Load Appointment Lists.", "Oops!");
            }
        }

        private void appointment_list_SelectedIndexChanged(object sender, EventArgs e)
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

        private void acknowledge_click(object sender, EventArgs e)
        {
            if (appointment_list.SelectedItems.Count == 0)
            {
                return;
            }
            appointment_list.SelectedItems[0].Remove();
            MessageBox.Show("Appointment Acknowledged.","Success");
            panel1.Hide();
        }

        private void refresh_click(object sender, EventArgs e)
        {
            panel1.Hide();
            appointment_list.Items.Clear();
            load_appointment();
        }
    }
}
