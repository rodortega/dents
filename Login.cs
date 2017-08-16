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

            Connection connect      = new Connection();
            MySqlConnection mysql   = new MySqlConnection(connect.credentials);
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
                    string user = reader.GetString("firstname") + " " + reader.GetString("lastname");
                    MessageBox.Show("Welcome, " + user + "!", "Login Successful");

                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect" , "Login Error");
                }

                mysql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Oops!");
            }
            
        }
    }
}
