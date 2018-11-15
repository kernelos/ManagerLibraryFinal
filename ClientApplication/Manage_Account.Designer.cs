namespace ClientApplication
{
    partial class Manage_Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cB_Search_follow = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Edit_Account = new System.Windows.Forms.PictureBox();
            this.btn_Remove_Account = new System.Windows.Forms.PictureBox();
            this.btn_Add_Account = new System.Windows.Forms.PictureBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panelNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cB_Search_follow);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Location = new System.Drawing.Point(352, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm theo:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(237, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 27);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cB_Search_follow
            // 
            this.cB_Search_follow.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên",
            "Mã số sinh viên"});
            this.cB_Search_follow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cB_Search_follow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Search_follow.FormattingEnabled = true;
            this.cB_Search_follow.Items.AddRange(new object[] {
            "Mã Số Sinh Viên",
            "Tên Sinh Viên",
            "Số CMND"});
            this.cB_Search_follow.Location = new System.Drawing.Point(94, 39);
            this.cB_Search_follow.Name = "cB_Search_follow";
            this.cB_Search_follow.Size = new System.Drawing.Size(117, 21);
            this.cB_Search_follow.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(15, 78);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 20);
            this.txt_Search.TabIndex = 8;
            // 
            // btn_Edit_Account
            // 
            this.btn_Edit_Account.Image = global::ClientApplication.Properties.Resources.user__2_;
            this.btn_Edit_Account.Location = new System.Drawing.Point(247, 94);
            this.btn_Edit_Account.Name = "btn_Edit_Account";
            this.btn_Edit_Account.Size = new System.Drawing.Size(68, 72);
            this.btn_Edit_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Edit_Account.TabIndex = 14;
            this.btn_Edit_Account.TabStop = false;
            this.btn_Edit_Account.Click += new System.EventHandler(this.btn_Edit_Account_Click);
            // 
            // btn_Remove_Account
            // 
            this.btn_Remove_Account.Image = global::ClientApplication.Properties.Resources.user__1_;
            this.btn_Remove_Account.Location = new System.Drawing.Point(153, 94);
            this.btn_Remove_Account.Name = "btn_Remove_Account";
            this.btn_Remove_Account.Size = new System.Drawing.Size(68, 72);
            this.btn_Remove_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Remove_Account.TabIndex = 13;
            this.btn_Remove_Account.TabStop = false;
            this.btn_Remove_Account.Click += new System.EventHandler(this.btn_Remove_Account_Click);
            // 
            // btn_Add_Account
            // 
            this.btn_Add_Account.Image = global::ClientApplication.Properties.Resources.user;
            this.btn_Add_Account.Location = new System.Drawing.Point(69, 94);
            this.btn_Add_Account.Name = "btn_Add_Account";
            this.btn_Add_Account.Size = new System.Drawing.Size(68, 72);
            this.btn_Add_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add_Account.TabIndex = 12;
            this.btn_Add_Account.TabStop = false;
            this.btn_Add_Account.Click += new System.EventHandler(this.btn_Add_Account_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToOrderColumns = true;
            this.dataGridViewStudent.AllowUserToResizeColumns = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            this.dataGridViewStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(127)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudent.ColumnHeadersHeight = 30;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudent.EnableHeadersVisualStyles = false;
            this.dataGridViewStudent.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewStudent.Location = new System.Drawing.Point(18, 221);
            this.dataGridViewStudent.MultiSelect = false;
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.dataGridViewStudent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(658, 310);
            this.dataGridViewStudent.TabIndex = 16;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(603, 188);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(55, 27);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.notify);
            this.panelNotify.Location = new System.Drawing.Point(18, 191);
            this.panelNotify.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(580, 21);
            this.panelNotify.TabIndex = 18;
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(2, 2);
            this.notify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 19);
            this.notify.TabIndex = 16;
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Manage_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 548);
            this.Controls.Add(this.panelNotify);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.btn_Edit_Account);
            this.Controls.Add(this.btn_Remove_Account);
            this.Controls.Add(this.btn_Add_Account);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Manage_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manage_Account_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Edit_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cB_Search_follow;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.PictureBox btn_Add_Account;
        private System.Windows.Forms.PictureBox btn_Remove_Account;
        private System.Windows.Forms.PictureBox btn_Edit_Account;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.Label notify;
    }
}