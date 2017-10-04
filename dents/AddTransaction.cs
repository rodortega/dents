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
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace dents
{
    public partial class AddTransaction : MaterialForm
    {
        public AddTransaction()
        {

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue700, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            refresh();
        }

        private void refresh()
        {
            load_patient();
            load_purpose();
            load_teeth();

            summary_list.Items.Clear();
            procedure_list.SelectedItems.Clear();

            patients_combobox.SelectedIndex = -1;
            teeth_combobox.SelectedIndex = -1;

            subtotal_textbox.Text = "0";
        }

        private void load_patient()
        {
            try
            {
                Controller.PatientController patient = new Controller.PatientController();
                DataTable data = patient.getAllPatients();

                Dictionary<string, string> source = new Dictionary<string, string>();

                foreach (DataRow row in data.Rows)
                {
                    source.Add(row["id"].ToString(), row["firstname"].ToString() + " " + row["lastname"].ToString());
                }

                patients_combobox.DataSource = new BindingSource(source, null);
                patients_combobox.DisplayMember = "Value";
                patients_combobox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Patients \n" + ex.ToString(), "Oops!");
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
                    list = new ListViewItem(row["procedure_name"].ToString());
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

        private void load_teeth()
        {
            Dictionary<string, string> source = new Dictionary<string, string>();

            source.Add("1", "1 - Upper Right Wisdom Tooth");
            source.Add("2", "2 - Upper Right 2nd Molar");
            source.Add("3", "3 - Upper Right 1st Molar");
            source.Add("4", "4 - Upper Right 2nd Bicuspid");
            source.Add("5", "5 - Upper Right 1st Bicuspid");
            source.Add("6", "6 - Upper Right Canine");
            source.Add("7", "7 - Upper Right Lateral Incisor");
            source.Add("8", "8 - Upper Right Central Incisor");
            source.Add("9", "9 - Upper Left Central Incisor");
            source.Add("10", "10 - Upper Left Lateral Incisor");
            source.Add("11", "11 - Upper Left Canine");
            source.Add("12", "12 - Upper Left 1st Bicuspid");
            source.Add("13", "13 - Upper Left 2nd Bicuspid");
            source.Add("14", "14 - Upper Left 1st Molar");
            source.Add("15", "15 - Upper Left 2nd Molar");
            source.Add("16", "16 - Upper Left Wisdom Tooth");
            source.Add("17", "17 - Lower Left Wisdom Tooth");
            source.Add("18", "18 - Lower Left 2nd Molar");
            source.Add("19", "19 - Lower Left 1st Molar");
            source.Add("20", "20 - Lower Left 2nd Bicuspid");
            source.Add("21", "21 - Lower Left 1st Bicuspid");
            source.Add("22", "22 - Lower Left Canine");
            source.Add("23", "23 - Lower Left Lateral Incisor");
            source.Add("24", "24 - Lower Left Central Incisor");
            source.Add("25", "25 - Lower Right Central Incisor");
            source.Add("26", "26 - Lower Right Lateral Incisor");
            source.Add("27", "27 - Lower Right Canine");
            source.Add("28", "28 - Lower Right 1st Bicuspid");
            source.Add("29", "29 - Lower Right 2nd Bicuspid");
            source.Add("30", "30 - Lower Right 1st Molar");
            source.Add("31", "31 - Lower Right 2nd Molar");
            source.Add("32", "32 - Lower Right Wisdom Tooth");

            teeth_combobox.DataSource = new BindingSource(source, null);
            teeth_combobox.DisplayMember = "Value";
            teeth_combobox.ValueMember = "Key";
        }

        private void add_click(Object sender, EventArgs e)
        {
            if (procedure_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a procedure first.", "Adding Error");
                return;
            }

            if(patients_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an existing patient first.", "Adding Error");
                return;
            }

            if (teeth_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an existing teeth number first.", "Adding Error");
                return;
            }

            ListViewItem item = procedure_list.SelectedItems[0];

            ListViewItem list = new ListViewItem(item.SubItems[0].Text);
            list.SubItems.Add(((KeyValuePair<string, string>)teeth_combobox.SelectedItem).Key);
            list.SubItems.Add(item.SubItems[1].Text);

            summary_list.Items.Add(list);

            subtotal_textbox.Text = (Convert.ToInt32(subtotal_textbox.Text) + Convert.ToInt32(item.SubItems[1].Text)).ToString();

            teeth_combobox.SelectedIndex = -1;
            procedure_list.SelectedItems.Clear();
        }

        private void checkout_click(Object sender, EventArgs e)
        {
            if (summary_list.Items.Count == 0)
            {
                MessageBox.Show("Please add atleast 1 procedure before checking out.", "Checkout Error");
                return;
            }

            if (patients_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an existing patient first.", "Adding Error");
                return;
            }

            try
            {
                Controller.HistoryController history = new Controller.HistoryController();

                foreach (ListViewItem item in summary_list.Items)
                {
                    string patient_id = ((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key;
                    string procedure_name = item.SubItems[0].Text;
                    string teeth_number = item.SubItems[1].Text;
                    string amount = item.SubItems[2].Text;
                    string datetime_create = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    history.addHistory(patient_id, procedure_name, teeth_number, amount, datetime_create);
                }

                Log.addToLog("ADD TRANSACTION", "[ PATIENT ID: " +((KeyValuePair<string, string>)patients_combobox.SelectedItem).Key + " ]");

                MessageBox.Show("Checkout Successful! Data is saved in patient's profile.", "Success");

                this.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Cannot save transaction \n" + ex.ToString(), "Saving Error");
            }

        }

        private void exit_application(Object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}
