namespace dents
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.lastame_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.save_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.birthday_textbox = new System.Windows.Forms.DateTimePicker();
            this.firstname_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.address_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phone_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lastame_textbox
            // 
            this.lastame_textbox.Depth = 0;
            this.lastame_textbox.Hint = "";
            this.lastame_textbox.Location = new System.Drawing.Point(263, 92);
            this.lastame_textbox.MaxLength = 32767;
            this.lastame_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastame_textbox.Name = "lastame_textbox";
            this.lastame_textbox.PasswordChar = '\0';
            this.lastame_textbox.SelectedText = "";
            this.lastame_textbox.SelectionLength = 0;
            this.lastame_textbox.SelectionStart = 0;
            this.lastame_textbox.Size = new System.Drawing.Size(112, 23);
            this.lastame_textbox.TabIndex = 1;
            this.lastame_textbox.TabStop = false;
            this.lastame_textbox.UseSystemPasswordChar = false;
            // 
            // save_button
            // 
            this.save_button.AutoSize = true;
            this.save_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_button.Depth = 0;
            this.save_button.Icon = ((System.Drawing.Image)(resources.GetObject("save_button.Icon")));
            this.save_button.Location = new System.Drawing.Point(292, 328);
            this.save_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_button.Name = "save_button";
            this.save_button.Primary = true;
            this.save_button.Size = new System.Drawing.Size(83, 36);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(38, 92);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "NAME:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(38, 123);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "PHONE:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(38, 156);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(79, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "ADDRESS:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(38, 190);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(84, 19);
            this.materialLabel6.TabIndex = 43;
            this.materialLabel6.Text = "BIRTHDAY:";
            // 
            // status_combobox
            // 
            this.status_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Location = new System.Drawing.Point(138, 260);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(235, 25);
            this.status_combobox.TabIndex = 6;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(38, 225);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 19);
            this.materialLabel7.TabIndex = 44;
            this.materialLabel7.Text = "GENDER:";
            // 
            // gender_combobox
            // 
            this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Location = new System.Drawing.Point(138, 223);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(235, 25);
            this.gender_combobox.TabIndex = 5;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(38, 261);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 19);
            this.materialLabel8.TabIndex = 45;
            this.materialLabel8.Text = "STATUS:";
            // 
            // birthday_textbox
            // 
            this.birthday_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_textbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday_textbox.Location = new System.Drawing.Point(138, 188);
            this.birthday_textbox.Name = "birthday_textbox";
            this.birthday_textbox.Size = new System.Drawing.Size(235, 25);
            this.birthday_textbox.TabIndex = 4;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Depth = 0;
            this.firstname_textbox.Hint = "";
            this.firstname_textbox.Location = new System.Drawing.Point(138, 92);
            this.firstname_textbox.MaxLength = 32767;
            this.firstname_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.PasswordChar = '\0';
            this.firstname_textbox.SelectedText = "";
            this.firstname_textbox.SelectionLength = 0;
            this.firstname_textbox.SelectionStart = 0;
            this.firstname_textbox.Size = new System.Drawing.Size(119, 23);
            this.firstname_textbox.TabIndex = 0;
            this.firstname_textbox.TabStop = false;
            this.firstname_textbox.UseSystemPasswordChar = false;
            // 
            // address_textbox
            // 
            this.address_textbox.Depth = 0;
            this.address_textbox.Hint = "";
            this.address_textbox.Location = new System.Drawing.Point(138, 156);
            this.address_textbox.MaxLength = 32767;
            this.address_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.PasswordChar = '\0';
            this.address_textbox.SelectedText = "";
            this.address_textbox.SelectionLength = 0;
            this.address_textbox.SelectionStart = 0;
            this.address_textbox.Size = new System.Drawing.Size(235, 23);
            this.address_textbox.TabIndex = 3;
            this.address_textbox.TabStop = false;
            this.address_textbox.UseSystemPasswordChar = false;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Depth = 0;
            this.phone_textbox.Hint = "";
            this.phone_textbox.Location = new System.Drawing.Point(138, 121);
            this.phone_textbox.MaxLength = 32767;
            this.phone_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.PasswordChar = '\0';
            this.phone_textbox.SelectedText = "";
            this.phone_textbox.SelectionLength = 0;
            this.phone_textbox.SelectionStart = 0;
            this.phone_textbox.Size = new System.Drawing.Size(235, 23);
            this.phone_textbox.TabIndex = 2;
            this.phone_textbox.TabStop = false;
            this.phone_textbox.UseSystemPasswordChar = false;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 376);
            this.Controls.Add(this.lastame_textbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.status_combobox);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.gender_combobox);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.birthday_textbox);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPatient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit_application);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lastame_textbox;
        private MaterialSkin.Controls.MaterialRaisedButton save_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox status_combobox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox gender_combobox;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker birthday_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstname_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField address_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField phone_textbox;
    }
}