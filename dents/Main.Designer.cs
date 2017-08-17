namespace dents
{
    partial class username
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(username));
            this.appointment_list = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patient_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.id_label = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.description_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.purpose_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.date_time_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.patient_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointment_list
            // 
            this.appointment_list.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.appointment_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointment_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.patient_name,
            this.schedule,
            this.title,
            this.description});
            this.appointment_list.Depth = 0;
            this.appointment_list.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.appointment_list.FullRowSelect = true;
            this.appointment_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.appointment_list.Location = new System.Drawing.Point(14, 121);
            this.appointment_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.appointment_list.MouseState = MaterialSkin.MouseState.OUT;
            this.appointment_list.MultiSelect = false;
            this.appointment_list.Name = "appointment_list";
            this.appointment_list.OwnerDraw = true;
            this.appointment_list.Size = new System.Drawing.Size(437, 473);
            this.appointment_list.TabIndex = 0;
            this.appointment_list.UseCompatibleStateImageBehavior = false;
            this.appointment_list.View = System.Windows.Forms.View.Details;
            this.appointment_list.SelectedIndexChanged += new System.EventHandler(this.appointment_list_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 70;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Name";
            this.patient_name.Width = 150;
            // 
            // schedule
            // 
            this.schedule.Text = "Date - Time";
            this.schedule.Width = 200;
            // 
            // title
            // 
            this.title.Text = "Subject";
            this.title.Width = 0;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "APPOINTMENTS";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.Icon")));
            this.materialRaisedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialRaisedButton1.Location = new System.Drawing.Point(460, 620);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(176, 36);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "New Transaction";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "DETAILS";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 50);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(31, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "ID: ";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Depth = 0;
            this.id_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.id_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.id_label.Location = new System.Drawing.Point(118, 50);
            this.id_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(70, 19);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "{id_label}";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialRaisedButton2);
            this.panel1.Controls.Add(this.description_label);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.purpose_label);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.date_time_label);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.patient_label);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Location = new System.Drawing.Point(458, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 224);
            this.panel1.TabIndex = 7;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(364, 8);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(120, 36);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "ACKNOWLEDGE";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.acknowledge_click);
            // 
            // description_label
            // 
            this.description_label.Depth = 0;
            this.description_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.description_label.Location = new System.Drawing.Point(118, 168);
            this.description_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(366, 45);
            this.description_label.TabIndex = 14;
            this.description_label.Text = "{description_label}";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 168);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(111, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "DESCRIPTION: ";
            // 
            // purpose_label
            // 
            this.purpose_label.AutoSize = true;
            this.purpose_label.Depth = 0;
            this.purpose_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.purpose_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.purpose_label.Location = new System.Drawing.Point(118, 136);
            this.purpose_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.purpose_label.Name = "purpose_label";
            this.purpose_label.Size = new System.Drawing.Size(112, 19);
            this.purpose_label.TabIndex = 12;
            this.purpose_label.Text = "{purpose_label}";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(9, 136);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(82, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "PURPOSE: ";
            // 
            // date_time_label
            // 
            this.date_time_label.AutoSize = true;
            this.date_time_label.Depth = 0;
            this.date_time_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.date_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.date_time_label.Location = new System.Drawing.Point(118, 107);
            this.date_time_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.date_time_label.Name = "date_time_label";
            this.date_time_label.Size = new System.Drawing.Size(124, 19);
            this.date_time_label.TabIndex = 10;
            this.date_time_label.Text = "{date_time_label}";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(9, 107);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "DATE/TIME : ";
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Depth = 0;
            this.patient_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.patient_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patient_label.Location = new System.Drawing.Point(118, 79);
            this.patient_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(109, 19);
            this.patient_label.TabIndex = 8;
            this.patient_label.Text = "{patient_name}";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 79);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "NAME:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(457, 311);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(490, 3);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton3.Icon")));
            this.materialRaisedButton3.Location = new System.Drawing.Point(638, 620);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(113, 36);
            this.materialRaisedButton3.TabIndex = 9;
            this.materialRaisedButton3.Text = "Patients";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton4.Icon")));
            this.materialRaisedButton4.Location = new System.Drawing.Point(753, 620);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(106, 36);
            this.materialRaisedButton4.TabIndex = 10;
            this.materialRaisedButton4.Text = "history";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton5.Icon")));
            this.materialRaisedButton5.Location = new System.Drawing.Point(862, 620);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton5.TabIndex = 11;
            this.materialRaisedButton5.Text = "logs";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(460, 327);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(118, 19);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "NOTIFICATIONS";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton6.Icon")));
            this.materialRaisedButton6.Location = new System.Drawing.Point(12, 620);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(107, 36);
            this.materialRaisedButton6.TabIndex = 13;
            this.materialRaisedButton6.Text = "REFRESH";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.refresh_click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(12, 606);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(936, 3);
            this.materialDivider2.TabIndex = 14;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 666);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.appointment_list);
            this.Name = "username";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENTS • DASHBOARD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView appointment_list;
        public System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader schedule;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader description;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel id_label;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel date_time_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel patient_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel description_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel purpose_label;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}