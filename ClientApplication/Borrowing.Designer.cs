namespace ClientApplication
{
    partial class Borrowing
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
            this.panelNotify = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewBookLeding = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSetting = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonReNewBook = new System.Windows.Forms.PictureBox();
            this.buttonReturnBook = new System.Windows.Forms.PictureBox();
            this.buttonAddBookLend = new System.Windows.Forms.PictureBox();
            this.panelNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookLeding)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReNewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturnBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddBookLend)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.notify);
            this.panelNotify.Location = new System.Drawing.Point(16, 189);
            this.panelNotify.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(580, 21);
            this.panelNotify.TabIndex = 26;
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
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(601, 186);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(55, 27);
            this.buttonRefresh.TabIndex = 25;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookLeding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookLeding.ColumnHeadersHeight = 30;
            this.dataGridViewBookLeding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBookLeding.EnableHeadersVisualStyles = false;
            this.dataGridViewBookLeding.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewBookLeding.Location = new System.Drawing.Point(16, 219);
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
            this.dataGridViewBookLeding.Size = new System.Drawing.Size(943, 310);
            this.dataGridViewBookLeding.TabIndex = 24;
            this.dataGridViewBookLeding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookLeding_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxSetting);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.textboxSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(403, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 102);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo MSSV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chế Độ:";
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
            this.comboBoxSetting.Location = new System.Drawing.Point(74, 29);
            this.comboBoxSetting.Name = "comboBoxSetting";
            this.comboBoxSetting.Size = new System.Drawing.Size(120, 25);
            this.comboBoxSetting.TabIndex = 30;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(202, 68);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 27);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.Location = new System.Drawing.Point(9, 71);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(176, 23);
            this.textboxSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lý Sách Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mượn Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Trả Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gia Hạn";
            // 
            // ButtonReNewBook
            // 
            this.ButtonReNewBook.Image = global::ClientApplication.Properties.Resources.notebookRenew;
            this.ButtonReNewBook.Location = new System.Drawing.Point(244, 93);
            this.ButtonReNewBook.Name = "ButtonReNewBook";
            this.ButtonReNewBook.Size = new System.Drawing.Size(68, 72);
            this.ButtonReNewBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonReNewBook.TabIndex = 23;
            this.ButtonReNewBook.TabStop = false;
            this.ButtonReNewBook.Click += new System.EventHandler(this.ButtonReNewBook_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Image = global::ClientApplication.Properties.Resources.notebookReturn;
            this.buttonReturnBook.Location = new System.Drawing.Point(139, 93);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(68, 72);
            this.buttonReturnBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonReturnBook.TabIndex = 22;
            this.buttonReturnBook.TabStop = false;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonAddBookLend
            // 
            this.buttonAddBookLend.Image = global::ClientApplication.Properties.Resources.notebook;
            this.buttonAddBookLend.Location = new System.Drawing.Point(34, 93);
            this.buttonAddBookLend.Name = "buttonAddBookLend";
            this.buttonAddBookLend.Size = new System.Drawing.Size(68, 72);
            this.buttonAddBookLend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAddBookLend.TabIndex = 21;
            this.buttonAddBookLend.TabStop = false;
            this.buttonAddBookLend.Click += new System.EventHandler(this.buttonAddBookLend_Click);
            // 
            // Borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelNotify);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewBookLeding);
            this.Controls.Add(this.ButtonReNewBook);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonAddBookLend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Borrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mượn sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Borrowing_FormClosed);
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookLeding)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReNewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturnBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddBookLend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.Label notify;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewBookLeding;
        private System.Windows.Forms.PictureBox ButtonReNewBook;
        private System.Windows.Forms.PictureBox buttonReturnBook;
        private System.Windows.Forms.PictureBox buttonAddBookLend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSetting;
    }
}