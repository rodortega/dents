namespace dents
{
    partial class Patients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.patients_combobox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.load_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.firstname_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phone_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.address_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.birthday_textbox = new System.Windows.Forms.DateTimePicker();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.id_textbox = new MaterialSkin.Controls.MaterialLabel();
            this.edit_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.appointment_list = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.transaction_list = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.lastame_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.addpatient_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patients_combobox
            // 
            this.patients_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.patients_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patients_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.patients_combobox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients_combobox.FormattingEnabled = true;
            this.patients_combobox.Location = new System.Drawing.Point(80, 85);
            this.patients_combobox.Name = "patients_combobox";
            this.patients_combobox.Size = new System.Drawing.Size(290, 25);
            this.patients_combobox.TabIndex = 17;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "NAME:";
            // 
            // load_button
            // 
            this.load_button.AutoSize = true;
            this.load_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.load_button.Depth = 0;
            this.load_button.Icon = ((System.Drawing.Image)(resources.GetObject("load_button.Icon")));
            this.load_button.Location = new System.Drawing.Point(288, 117);
            this.load_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.load_button.Name = "load_button";
            this.load_button.Primary = true;
            this.load_button.Size = new System.Drawing.Size(82, 36);
            this.load_button.TabIndex = 19;
            this.load_button.Text = "VIEW";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.view_click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "PROFILE";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(34, 85);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "NAME:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(34, 121);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "PHONE:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(34, 156);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(79, 19);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "ADDRESS:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(34, 190);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(84, 19);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "BIRTHDAY:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(34, 225);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 19);
            this.materialLabel7.TabIndex = 25;
            this.materialLabel7.Text = "GENDER:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(34, 261);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 19);
            this.materialLabel8.TabIndex = 26;
            this.materialLabel8.Text = "STATUS:";
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Depth = 0;
            this.firstname_textbox.Hint = "";
            this.firstname_textbox.Location = new System.Drawing.Point(134, 92);
            this.firstname_textbox.MaxLength = 32767;
            this.firstname_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.PasswordChar = '\0';
            this.firstname_textbox.SelectedText = "";
            this.firstname_textbox.SelectionLength = 0;
            this.firstname_textbox.SelectionStart = 0;
            this.firstname_textbox.Size = new System.Drawing.Size(119, 23);
            this.firstname_textbox.TabIndex = 27;
            this.firstname_textbox.TabStop = false;
            this.firstname_textbox.UseSystemPasswordChar = false;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Depth = 0;
            this.phone_textbox.Hint = "";
            this.phone_textbox.Location = new System.Drawing.Point(134, 121);
            this.phone_textbox.MaxLength = 32767;
            this.phone_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.PasswordChar = '\0';
            this.phone_textbox.SelectedText = "";
            this.phone_textbox.SelectionLength = 0;
            this.phone_textbox.SelectionStart = 0;
            this.phone_textbox.Size = new System.Drawing.Size(235, 23);
            this.phone_textbox.TabIndex = 28;
            this.phone_textbox.TabStop = false;
            this.phone_textbox.UseSystemPasswordChar = false;
            // 
            // address_textbox
            // 
            this.address_textbox.Depth = 0;
            this.address_textbox.Hint = "";
            this.address_textbox.Location = new System.Drawing.Point(134, 156);
            this.address_textbox.MaxLength = 32767;
            this.address_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.PasswordChar = '\0';
            this.address_textbox.SelectedText = "";
            this.address_textbox.SelectionLength = 0;
            this.address_textbox.SelectionStart = 0;
            this.address_textbox.Size = new System.Drawing.Size(235, 23);
            this.address_textbox.TabIndex = 29;
            this.address_textbox.TabStop = false;
            this.address_textbox.UseSystemPasswordChar = false;
            // 
            // birthday_textbox
            // 
            this.birthday_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_textbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday_textbox.Location = new System.Drawing.Point(134, 188);
            this.birthday_textbox.Name = "birthday_textbox";
            this.birthday_textbox.Size = new System.Drawing.Size(235, 25);
            this.birthday_textbox.TabIndex = 30;
            // 
            // gender_combobox
            // 
            this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Location = new System.Drawing.Point(134, 223);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(235, 25);
            this.gender_combobox.TabIndex = 31;
            // 
            // status_combobox
            // 
            this.status_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Location = new System.Drawing.Point(134, 260);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(235, 25);
            this.status_combobox.TabIndex = 32;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(34, 48);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(27, 19);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "ID:";
            // 
            // id_textbox
            // 
            this.id_textbox.AutoSize = true;
            this.id_textbox.Depth = 0;
            this.id_textbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.id_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.id_textbox.Location = new System.Drawing.Point(130, 48);
            this.id_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(33, 19);
            this.id_textbox.TabIndex = 34;
            this.id_textbox.Text = "{ID}";
            // 
            // edit_button
            // 
            this.edit_button.AutoSize = true;
            this.edit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit_button.Depth = 0;
            this.edit_button.Icon = ((System.Drawing.Image)(resources.GetObject("edit_button.Icon")));
            this.edit_button.Location = new System.Drawing.Point(38, 323);
            this.edit_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_button.Name = "edit_button";
            this.edit_button.Primary = true;
            this.edit_button.Size = new System.Drawing.Size(78, 36);
            this.edit_button.TabIndex = 35;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_click);
            // 
            // save_button
            // 
            this.save_button.AutoSize = true;
            this.save_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_button.Depth = 0;
            this.save_button.Icon = ((System.Drawing.Image)(resources.GetObject("save_button.Icon")));
            this.save_button.Location = new System.Drawing.Point(288, 323);
            this.save_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_button.Name = "save_button";
            this.save_button.Primary = true;
            this.save_button.Size = new System.Drawing.Size(83, 36);
            this.save_button.TabIndex = 36;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lastame_textbox);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.status_combobox);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.gender_combobox);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.birthday_textbox);
            this.panel1.Controls.Add(this.firstname_textbox);
            this.panel1.Controls.Add(this.address_textbox);
            this.panel1.Controls.Add(this.phone_textbox);
            this.panel1.Location = new System.Drawing.Point(-1, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 389);
            this.panel1.TabIndex = 37;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(403, 87);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(122, 19);
            this.materialLabel10.TabIndex = 38;
            this.materialLabel10.Text = "APPOINTMENTS";
            // 
            // appointment_list
            // 
            this.appointment_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointment_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.appointment_list.Depth = 0;
            this.appointment_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.appointment_list.FullRowSelect = true;
            this.appointment_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointment_list.Location = new System.Drawing.Point(407, 117);
            this.appointment_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.appointment_list.MouseState = MaterialSkin.MouseState.OUT;
            this.appointment_list.Name = "appointment_list";
            this.appointment_list.OwnerDraw = true;
            this.appointment_list.Size = new System.Drawing.Size(259, 444);
            this.appointment_list.TabIndex = 39;
            this.appointment_list.UseCompatibleStateImageBehavior = false;
            this.appointment_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Purpose";
            this.columnHeader2.Width = 170;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(690, 87);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(120, 19);
            this.materialLabel11.TabIndex = 40;
            this.materialLabel11.Text = "TRANSACTIONS";
            // 
            // transaction_list
            // 
            this.transaction_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transaction_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.transaction_list.Depth = 0;
            this.transaction_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.transaction_list.FullRowSelect = true;
            this.transaction_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.transaction_list.Location = new System.Drawing.Point(694, 117);
            this.transaction_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.transaction_list.MouseState = MaterialSkin.MouseState.OUT;
            this.transaction_list.Name = "transaction_list";
            this.transaction_list.OwnerDraw = true;
            this.transaction_list.Size = new System.Drawing.Size(348, 444);
            this.transaction_list.TabIndex = 41;
            this.transaction_list.UseCompatibleStateImageBehavior = false;
            this.transaction_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Procedure";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 100;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(677, 82);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(3, 500);
            this.materialDivider2.TabIndex = 43;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // lastame_textbox
            // 
            this.lastame_textbox.Depth = 0;
            this.lastame_textbox.Hint = "";
            this.lastame_textbox.Location = new System.Drawing.Point(259, 92);
            this.lastame_textbox.MaxLength = 32767;
            this.lastame_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastame_textbox.Name = "lastame_textbox";
            this.lastame_textbox.PasswordChar = '\0';
            this.lastame_textbox.SelectedText = "";
            this.lastame_textbox.SelectionLength = 0;
            this.lastame_textbox.SelectionStart = 0;
            this.lastame_textbox.Size = new System.Drawing.Size(112, 23);
            this.lastame_textbox.TabIndex = 37;
            this.lastame_textbox.TabStop = false;
            this.lastame_textbox.UseSystemPasswordChar = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(15, 579);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1020, 3);
            this.materialDivider3.TabIndex = 44;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(388, 82);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(3, 500);
            this.materialDivider1.TabIndex = 45;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // addpatient_button
            // 
            this.addpatient_button.AutoSize = true;
            this.addpatient_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addpatient_button.Depth = 0;
            this.addpatient_button.Icon = ((System.Drawing.Image)(resources.GetObject("addpatient_button.Icon")));
            this.addpatient_button.Location = new System.Drawing.Point(904, 593);
            this.addpatient_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.addpatient_button.Name = "addpatient_button";
            this.addpatient_button.Primary = true;
            this.addpatient_button.Size = new System.Drawing.Size(138, 36);
            this.addpatient_button.TabIndex = 46;
            this.addpatient_button.Text = "new patient";
            this.addpatient_button.UseVisualStyleBackColor = true;
            this.addpatient_button.Click += new System.EventHandler(this.addpatient_click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 641);
            this.Controls.Add(this.addpatient_button);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.transaction_list);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.appointment_list);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.patients_combobox);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit_application);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patients_combobox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton load_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstname_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField phone_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField address_textbox;
        private System.Windows.Forms.DateTimePicker birthday_textbox;
        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.ComboBox status_combobox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel id_textbox;
        private MaterialSkin.Controls.MaterialRaisedButton edit_button;
        private MaterialSkin.Controls.MaterialRaisedButton save_button;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialListView appointment_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialListView transaction_list;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastame_textbox;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton addpatient_button;
    }
}