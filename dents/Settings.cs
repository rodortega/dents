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
            panel3.Hide();
            load_users();


            if (User.id != "1")
            {
                delete_user_button.Visible = false;
                panel4.Hide();
            }
        }

        private void load_user()
        {
            try
            {
                Controller.UserController user = new Controller.UserController();
                DataTable data = user.getUserById(Convert.ToInt32(User.id));

                foreach(DataRow row in data.Rows)
                {
                    id_label.Text = row["id"].ToString();

                    username_textbox.Text   = row["username"].ToString();
                    firstname_textbox.Text  = row["firstname"].ToString();
                    lastname_textbox.Text   = row["lastname"].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load User. \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_purpose()
        {
            try
            {
                Controller.PurposeController purpose = new Controller.PurposeController();
                DataTable dt = purpose.getAllPurpose();

                ListViewItem list;

                procedure_list.ListViewItemSorter = null;
                procedure_list.BeginUpdate();

                foreach (DataRow row in dt.Rows)
                {
                    list = new ListViewItem(row["id"].ToString());
                    list.SubItems.Add(row["procedure_name"].ToString());
                    list.SubItems.Add(row["amount"].ToString());

                    procedure_list.Items.Add(list);
                }

                procedure_list.EndUpdate();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Procedures \n" + ex.ToString(), "Oops!");
            }
        }

        private void load_users()
        {
            try
            {
                Controller.UserController user = new Controller.UserController();
                DataTable data = user.getOtherUsers();

                ListViewItem list;

                users_list.ListViewItemSorter = null;
                users_list.BeginUpdate();

                foreach(DataRow row in data.Rows)
                {
                    list = new ListViewItem(row["id"].ToString());
                    list.SubItems.Add(row["username"].ToString());
                    list.SubItems.Add(row["firstname"].ToString() + " " + row["firstname"].ToString());

                    users_list.Items.Add(list);
                }

                users_list.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Users! \n" + ex.ToString(), "Oops!");
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

        private void users_list_click(Object sender, EventArgs e)
        {
            if (users_list.SelectedItems.Count > 0)
            {
                ListViewItem item = users_list.SelectedItems[0];

                users_id_label.Text = item.SubItems[0].Text;
                users_username_label.Text = item.SubItems[1].Text;
                users_fullname_label.Text = item.SubItems[2].Text;
                panel3.Show();
            }
        }

        private void delete_users_click(Object sender, EventArgs e)
        {
            try
            {
                Controller.UserController user = new Controller.UserController();
                user.deleteUser(Convert.ToInt32(users_id_label.Text));

                MessageBox.Show("User Deleted.", "Success");

                ListViewItem item = users_list.SelectedItems[0];

                item.Remove();

                panel3.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save Procedure. \n" + ex.ToString(), "Oops!");
            }
        }

        private void delete_procedure_click(Object sender, EventArgs e)
        {
            try
            {
                Controller.PurposeController purpose = new Controller.PurposeController();
                purpose.deletePurpose(Convert.ToInt32(procedure_id_label.Text));

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

            try
            {
                string id = procedure_id_label.Text;
                string procedure_name = procedure_name_textbox.Text;
                string procedure_amount = procedure_amount_textbox.Text;

                Controller.PurposeController purpose = new Controller.PurposeController();
                purpose.updatePurpose(id, procedure_name, procedure_amount);
                    


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

        private void save_new_users_click(Object sender, EventArgs e)
        {
            if (new_firstname_label.Text == "" || new_lastname_label.Text == "" || new_username_label.Text == "" || new_password_label.Text == "")
            {
                MessageBox.Show("All fields are required.", "Saving Error");
                return;
            }

            try
            {
                string username = new_username_label.Text;
                string password = new_password_label.Text;
                string firstname = new_firstname_label.Text;
                string lastname = new_lastname_label.Text;

                Controller.UserController user = new Controller.UserController();
                int last_id = user.addUser(username,password,firstname,lastname);

                MessageBox.Show("User Saved.", "Success");

                ListViewItem list;

                list = new ListViewItem(last_id.ToString());
                list.SubItems.Add(new_username_label.Text);
                list.SubItems.Add(new_firstname_label.Text + " " + new_lastname_label.Text);

                users_list.Items.Add(list);

                new_firstname_label.Text    = "";
                new_lastname_label.Text     = "";
                new_username_label.Text     = "";
                new_password_label.Text     = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Save User. \n" + ex.ToString(), "Oops!");
            }
        }

        private void save_new_procedure_click(Object sender, EventArgs e)
        {
            if (new_procedure_name_textbox.Text == "" || new_procedure_amount_textbox.Text == "")
            {
                MessageBox.Show("All fields are required.", "Saving Error");
                return;
            }

            try
            {
                string procedure_name = new_procedure_name_textbox.Text;
                string procedure_amount = new_procedure_amount_textbox.Text;

                Controller.PurposeController purpose = new Controller.PurposeController();
                int last_id = purpose.addPurpose(procedure_name, procedure_amount);

                MessageBox.Show("Procedure Saved.", "Success");

                ListViewItem list;

                list = new ListViewItem(last_id.ToString());
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
            try
            {
                string id = User.id;
                string username = username_textbox.Text;
                string firstname = firstname_textbox.Text;
                string lastname = lastname_textbox.Text;

                Controller.UserController user = new Controller.UserController();
                user.updateUser(id, username, firstname, lastname);

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

            try
            {
                string id = User.id;
                string password = newpassword_textbox.Text;

                Controller.UserController user = new Controller.UserController();
                user.changePassword(id, password);

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
