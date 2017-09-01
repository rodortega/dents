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
    public partial class Settings : MaterialForm
    {
        public Settings()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            load_user();
            load_purpose();
            panel1.Hide();
        }

        private void load_user()
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM users WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", User.id);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_label.Text = reader.GetString("id");

                    username_textbox.Text   = reader.GetString("username");
                    firstname_textbox.Text  = reader.GetString("firstname");
                    lastname_textbox.Text   = reader.GetString("lastname");
                }

                mysql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load User. \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_purpose()
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT id, procedure_name, amount FROM procedures";
            cmd.Connection = mysql;

            ListViewItem list;

            procedure_list.ListViewItemSorter = null;
            procedure_list.BeginUpdate();

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list = new ListViewItem(reader.GetString("id"));
                    list.SubItems.Add(reader.GetString("procedure_name"));
                    list.SubItems.Add(reader.GetString("amount"));

                    procedure_list.Items.Add(list);
                }
                procedure_list.EndUpdate();
                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Procedures \n" + ex.ToString(), "Oops!");
            }
        }

        private void purpose_list_click(Object sender, EventArgs e)
        {
            if (procedure_list.SelectedItems.Count > 0)
            {
                ListViewItem item = procedure_list.SelectedItems[0];

                procedure_id_label.Text = item.SubItems[0].Text;
                procedure_name_textbox.Text = item.SubItems[1].Text;
                procedure_amount_textbox.Text = item.SubItems[2].Text;
                panel1.Show();
            }
        }

        private void delete_procedure_click(Object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM procedures WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", procedure_id_label.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                MessageBox.Show("Procedure Deleted.", "Success");

                ListViewItem item = procedure_list.SelectedItems[0];

                item.Remove();

                panel1.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save Procedure. \n" + ex.ToString(), "Oops!");
            }
        }

        private void save_update_procedure_click(Object sender, EventArgs e)
        {
            if (procedure_name_textbox.Text == "" || procedure_amount_textbox.Text == "")
            {
                MessageBox.Show("All fields are required.", "Saving Error");
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE procedures SET procedure_name = @procedure_name, amount = @procedure_amount WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", procedure_id_label.Text);
            cmd.Parameters.AddWithValue("@procedure_name", procedure_name_textbox.Text);
            cmd.Parameters.AddWithValue("@procedure_amount", procedure_amount_textbox.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                MessageBox.Show("Procedure Saved.", "Success");

                ListViewItem item = procedure_list.SelectedItems[0];

                item.SubItems[1].Text = procedure_name_textbox.Text;
                item.SubItems[2].Text = procedure_amount_textbox.Text;

                panel1.Hide();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save Procedure. \n" + ex.ToString(), "Oops!");
            }
        }

        private void save_new_procedure_click(Object sender, EventArgs e)
        {
            if (new_procedure_name_textbox.Text == "" || new_procedure_amount_textbox.Text == "")
            {
                MessageBox.Show("All fields are required.", "Saving Error");
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO procedures(procedure_name,amount) VALUES(@procedure_name,@procedure_amount)";
            cmd.Parameters.AddWithValue("@procedure_name", new_procedure_name_textbox.Text);
            cmd.Parameters.AddWithValue("@procedure_amount", new_procedure_amount_textbox.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                MessageBox.Show("Procedure Saved.", "Success");

                ListViewItem list;

                list = new ListViewItem(cmd.LastInsertedId.ToString());
                list.SubItems.Add(new_procedure_name_textbox.Text);
                list.SubItems.Add(new_procedure_amount_textbox.Text);
                procedure_list.Items.Add(list);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save Procedure. \n" + ex.ToString(), "Oops!");
            }
        }

        private void save_basic_click(Object sender, EventArgs e)
        {
            if (username_textbox.Text == "" || firstname_textbox.Text == "" || lastname_textbox.Text == "")
            {
                MessageBox.Show("All fields are required.","Saving Error");
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE users SET username = @username, firstname = @firstname, lastname = @lastname WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", User.id);
            cmd.Parameters.AddWithValue("@username", username_textbox.Text);
            cmd.Parameters.AddWithValue("@firstname", firstname_textbox.Text);
            cmd.Parameters.AddWithValue("@lastname", lastname_textbox.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                MessageBox.Show("Profile Saved.","Success");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save Basic Info. \n" + ex.ToString(), "Oops!");
            }
        }

        private void save_password_click(Object sender, EventArgs e)
        {
            if (oldpassword_textbox.Text == "" || newpassword_textbox.Text == "" || retypenewpassword_textbox.Text == "")
            {
                MessageBox.Show("All fields are required.", "Password Error");
                return;
            }

            if (newpassword_textbox.Text != retypenewpassword_textbox.Text)
            {
                MessageBox.Show("New Password and the Retry New Password does not match", "Password Error");
                return;
            }

            if (oldpassword_textbox.Text != User.password)
            {
                MessageBox.Show("The old password is incorrect", "Password Error");
                return;
            }

            MySqlConnection mysql = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE users SET password = @password WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", User.id);
            cmd.Parameters.AddWithValue("@password", newpassword_textbox.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();
                cmd.ExecuteNonQuery();
                mysql.Close();

                MessageBox.Show("Password Changed.", "Success");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Save error. \n" + ex.ToString(), "Oops!");
            }
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
