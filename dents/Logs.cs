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
    public partial class Logs : MaterialForm
    {
        public Logs()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            load_logs();
            load_users();
            users_combobox.SelectedValue = "0";
        }

        private void load_logs()
        {
            logs_list.Items.Clear();

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT logs.*, users.firstname, users.lastname FROM logs JOIN users on users.id = logs.user_id ORDER BY id DESC LIMIT 50";
            cmd.Connection = mysql;

            // make listview faster by BeginUpdate() then EndUpdate() after
            logs_list.ListViewItemSorter = null;
            logs_list.BeginUpdate();

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                ListViewItem list;

                while (reader.Read())
                {
                    // format datetime to pretty format
                    string datetime = reader.GetString("datetime_create");
                    DateTime datetime_pretty = DateTime.Parse(datetime);
                    // add everything from DB to listview
                    list = new ListViewItem(reader.GetString("id"));
                    list.SubItems.Add(reader.GetString("title"));
                    list.SubItems.Add(reader.GetString("description"));
                    list.SubItems.Add(reader.GetString("firstname") + ' ' + reader.GetString("lastname"));
                    list.SubItems.Add(datetime_pretty.ToString("MMM dd yyyy, hh:mm tt"));   
                    logs_list.Items.Add(list);

                }
                // EndUpdate triggers the drawing of the listview
                logs_list.EndUpdate();
                mysql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Logs: \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_users()
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT id, firstname, lastname FROM users";
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

                source.Add("0", "All");

                users_combobox.DataSource = new BindingSource(source, null);
                users_combobox.DisplayMember = "Value";
                users_combobox.ValueMember = "Key";

                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Users! \n" + ex.ToString(), "Oops!");
            }
        }

        private void search_click(Object sender, EventArgs e)
        {
            DateTime datefrom_pretty = DateTime.Parse(datefrom_textbox.Text);
            DateTime dateto_pretty = DateTime.Parse(dateto_textbox.Text).AddDays(1);

            logs_list.Items.Clear();

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            if (((KeyValuePair<string, string>)users_combobox.SelectedItem).Key == "0")
            {
                cmd.CommandText = "SELECT logs.*, users.firstname, users.lastname FROM logs JOIN users on users.id = logs.user_id WHERE datetime_create BETWEEN @datefrom AND @dateto ORDER BY datetime_create DESC";
            }
            else
            {
                cmd.CommandText = "SELECT logs.*, users.firstname, users.lastname FROM logs JOIN users on users.id = logs.user_id WHERE logs.user_id = @id AND datetime_create BETWEEN @datefrom AND @dateto ORDER BY datetime_create DESC";
                cmd.Parameters.AddWithValue("@id", ((KeyValuePair<string, string>)users_combobox.SelectedItem).Key);
            }
            
            cmd.Parameters.AddWithValue("@datefrom", datefrom_pretty.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@dateto", dateto_pretty.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Connection = mysql;

            // make listview faster by BeginUpdate() then EndUpdate() after
            logs_list.ListViewItemSorter = null;
            logs_list.BeginUpdate();

            try
            {
                mysql.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                ListViewItem list;

                while (reader.Read())
                {
                    // format datetime to pretty format
                    string datetime = reader.GetString("datetime_create");
                    DateTime datetime_pretty = DateTime.Parse(datetime);
                    // add everything from DB to listview
                    list = new ListViewItem(reader.GetString("id"));
                    list.SubItems.Add(reader.GetString("title"));
                    list.SubItems.Add(reader.GetString("description"));
                    list.SubItems.Add(reader.GetString("firstname") + ' ' + reader.GetString("lastname"));
                    list.SubItems.Add(datetime_pretty.ToString("MMM dd yyyy, hh:mm tt"));
                    logs_list.Items.Add(list);

                }
                // EndUpdate triggers the drawing of the listview
                logs_list.EndUpdate();
                mysql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot find Data: \n" + ex.ToString(), "Oops!");
            }
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
