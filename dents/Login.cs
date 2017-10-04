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

            try
            {
                Controller.UserController user = new Controller.UserController();
                DataTable data = user.getUserByCredential(username.Text, password.Text);

                if(data.Rows.Count >= 1)
                {
                    User.fullname = data.Rows[0]["firstname"].ToString() + " " + data.Rows[0]["lastname"].ToString();
                    User.id = data.Rows[0]["id"].ToString();
                    User.password = data.Rows[0]["password"].ToString();
                   
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
