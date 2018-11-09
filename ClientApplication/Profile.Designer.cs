namespace ClientApplication
{
    partial class Profile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBookLeding = new System.Windows.Forms.DataGridView();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Personalid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_StudenId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSetting = new System.Windows.Forms.ComboBox();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookLeding)).BeginInit();
            this.panelNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 125);
            this.panel1.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.BackgroundImage = global::ClientApplication.Properties.Resources.documentsmaller;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEdit.Location = new System.Drawing.Point(614, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(68, 77);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(140, 14);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(91, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ClientApplication.Properties.Resources.network;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewBookLeding
            // 
            this.dataGridViewBookLeding.AllowUserToAddRows = false;
            this.dataGridViewBookLeding.AllowUserToDeleteRows = false;
            this.dataGridViewBookLeding.AllowUserToOrderColumns = true;
            this.dataGridViewBookLeding.AllowUserToResizeColumns = false;
            this.dataGridViewBookLeding.AllowUserToResizeRows = false;
            this.dataGridViewBookLeding.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBookLeding.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewBookLeding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBookLeding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBookLeding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(127)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookLeding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookLeding.ColumnHeadersHeight = 30;
            this.dataGridViewBookLeding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBookLeding.EnableHeadersVisualStyles = false;
            this.dataGridViewBookLeding.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewBookLeding.Location = new System.Drawing.Point(0, 493);
            this.dataGridViewBookLeding.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewBookLeding.MultiSelect = false;
            this.dataGridViewBookLeding.Name = "dataGridViewBookLeding";
            this.dataGridViewBookLeding.ReadOnly = true;
            this.dataGridViewBookLeding.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.dataGridViewBookLeding.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookLeding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookLeding.Size = new System.Drawing.Size(690, 163);
            this.dataGridViewBookLeding.TabIndex = 25;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(214, 303);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(347, 23);
            this.txt_Password.TabIndex = 42;
            // 
            // txt_Personalid
            // 
            this.txt_Personalid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Personalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Personalid.Location = new System.Drawing.Point(214, 248);
            this.txt_Personalid.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Personalid.Name = "txt_Personalid";
            this.txt_Personalid.Size = new System.Drawing.Size(347, 23);
            this.txt_Personalid.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số CMND:";
            // 
            // txt_Date
            // 
            this.txt_Date.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.txt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_Date.Location = new System.Drawing.Point(214, 352);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Date.MaxDate = new System.DateTime(2160, 12, 31, 0, 0, 0, 0);
            this.txt_Date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ShowUpDown = true;
            this.txt_Date.Size = new System.Drawing.Size(347, 23);
            this.txt_Date.TabIndex = 40;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(214, 197);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(347, 23);
            this.txt_Name.TabIndex = 39;
            // 
            // txt_StudenId
            // 
            this.txt_StudenId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_StudenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudenId.Location = new System.Drawing.Point(214, 148);
            this.txt_StudenId.Margin = new System.Windows.Forms.Padding(5);
            this.txt_StudenId.Name = "txt_StudenId";
            this.txt_StudenId.Size = new System.Drawing.Size(347, 23);
            this.txt_StudenId.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Họ và Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã số sinh viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 457);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Lịch Sử Mượn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Chế Độ:";
            // 
            // comboBoxSetting
            // 
            this.comboBoxSetting.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên",
            "Mã số sinh viên"});
            this.comboBoxSetting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSetting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSetting.FormattingEnabled = true;
            this.comboBoxSetting.Items.AddRange(new object[] {
            "Đã Trả",
            "Chưa Trả",
            "Tất Cả"});
            this.comboBoxSetting.Location = new System.Drawing.Point(440, 454);
            this.comboBoxSetting.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSetting.Name = "comboBoxSetting";
            this.comboBoxSetting.Size = new System.Drawing.Size(196, 25);
            this.comboBoxSetting.TabIndex = 45;
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.notify);
            this.panelNotify.Location = new System.Drawing.Point(154, 387);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(360, 43);
            this.panelNotify.TabIndex = 49;
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(3, 3);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 19);
            this.notify.TabIndex = 16;
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Filter
            // 
            this.Filter.BackgroundImage = global::ClientApplication.Properties.Resources.filter;
            this.Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Filter.Location = new System.Drawing.Point(644, 451);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(38, 34);
            this.Filter.TabIndex = 47;
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::ClientApplication.Properties.Resources.savesmall;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSave.Location = new System.Drawing.Point(520, 387);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(41, 41);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 662);
            this.Controls.Add(this.panelNotify);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSetting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Personalid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_StudenId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewBookLeding);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookLeding)).EndInit();
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBookLeding;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Personalid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_StudenId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSetting;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.Label notify;
    }
}