namespace dents
{
    partial class AddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.patients_combobox = new System.Windows.Forms.ComboBox();
            this.summary_list = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.procedure_list = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.teeth_combobox = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.subtotal_textbox = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "NAME: ";
            // 
            // patients_combobox
            // 
            this.patients_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.patients_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patients_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.patients_combobox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients_combobox.FormattingEnabled = true;
            this.patients_combobox.Location = new System.Drawing.Point(140, 89);
            this.patients_combobox.Name = "patients_combobox";
            this.patients_combobox.Size = new System.Drawing.Size(242, 25);
            this.patients_combobox.Sorted = true;
            this.patients_combobox.TabIndex = 17;
            // 
            // summary_list
            // 
            this.summary_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.summary_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.summary_list.Depth = 0;
            this.summary_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.summary_list.FullRowSelect = true;
            this.summary_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summary_list.Location = new System.Drawing.Point(394, 135);
            this.summary_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.summary_list.MouseState = MaterialSkin.MouseState.OUT;
            this.summary_list.Name = "summary_list";
            this.summary_list.OwnerDraw = true;
            this.summary_list.Size = new System.Drawing.Size(408, 441);
            this.summary_list.TabIndex = 25;
            this.summary_list.UseCompatibleStateImageBehavior = false;
            this.summary_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Purpose";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Teeth Type";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 100;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 154);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "PROCEDURES";
            // 
            // procedure_list
            // 
            this.procedure_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.procedure_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.procedure_list.Depth = 0;
            this.procedure_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.procedure_list.FullRowSelect = true;
            this.procedure_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.procedure_list.Location = new System.Drawing.Point(29, 241);
            this.procedure_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.procedure_list.MouseState = MaterialSkin.MouseState.OUT;
            this.procedure_list.Name = "procedure_list";
            this.procedure_list.OwnerDraw = true;
            this.procedure_list.Size = new System.Drawing.Size(353, 326);
            this.procedure_list.TabIndex = 28;
            this.procedure_list.UseCompatibleStateImageBehavior = false;
            this.procedure_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Procedure";
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 100;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(402, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "SUMMARY";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(389, 89);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(3, 550);
            this.materialDivider2.TabIndex = 30;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(49, 198);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 19);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "TEETH TYPE:";
            // 
            // teeth_combobox
            // 
            this.teeth_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teeth_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teeth_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.teeth_combobox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teeth_combobox.FormattingEnabled = true;
            this.teeth_combobox.Location = new System.Drawing.Point(155, 196);
            this.teeth_combobox.Name = "teeth_combobox";
            this.teeth_combobox.Size = new System.Drawing.Size(228, 25);
            this.teeth_combobox.TabIndex = 33;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.Icon")));
            this.materialRaisedButton1.Location = new System.Drawing.Point(306, 603);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton1.TabIndex = 35;
            this.materialRaisedButton1.Text = "ADD";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.add_click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton2.Icon")));
            this.materialRaisedButton2.Location = new System.Drawing.Point(679, 603);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(123, 36);
            this.materialRaisedButton2.TabIndex = 36;
            this.materialRaisedButton2.Text = "CHECK OUT";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.checkout_click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(402, 611);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(87, 19);
            this.materialLabel5.TabIndex = 37;
            this.materialLabel5.Text = "SUBTOTAL:";
            // 
            // subtotal_textbox
            // 
            this.subtotal_textbox.AutoSize = true;
            this.subtotal_textbox.Depth = 0;
            this.subtotal_textbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.subtotal_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subtotal_textbox.Location = new System.Drawing.Point(503, 610);
            this.subtotal_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.subtotal_textbox.Name = "subtotal_textbox";
            this.subtotal_textbox.Size = new System.Drawing.Size(17, 19);
            this.subtotal_textbox.TabIndex = 38;
            this.subtotal_textbox.Text = "0";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 654);
            this.Controls.Add(this.subtotal_textbox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.teeth_combobox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.procedure_list);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.summary_list);
            this.Controls.Add(this.patients_combobox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit_application);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox patients_combobox;
        private MaterialSkin.Controls.MaterialListView summary_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView procedure_list;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox teeth_combobox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel subtotal_textbox;
    }
}