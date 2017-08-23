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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void login_submit(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Fields cannot be empty.", "Login Error");
                return;
            }

            MySqlConnection mysql   = new MySqlConnection(Connection.credentials);
            MySqlCommand cmd        = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.Connection = mysql;

            try
            {
                mysql.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    User.fullname = reader.GetString("firstname") + " " + reader.GetString("lastname");
                    User.id = reader.GetString("id");
                   
                    Log.addToLog("LOGIN", "[ USER ID: " + User.id + " ]");

                    MessageBox.Show("Welcome, " + User.fullname + "!", "Login Successful");

               
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }

                else
                {
                    MessageBox.Show("Username or Password is Incorrect" , "Login Error");
                }

                mysql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("MySQL and/or Mysql Connector is not installed/opened. \n " + ex,"Oops!");
            }
            
        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
