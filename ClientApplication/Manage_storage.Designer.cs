namespace ClientApplication
{
    partial class Manage_Storage
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
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cB_Search_follow = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_EditBook = new System.Windows.Forms.PictureBox();
            this.btn_RemoveBook = new System.Windows.Forms.PictureBox();
            this.btn_AddBook = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.Label();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RemoveBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddBook)).BeginInit();
            this.panelNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý kho";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AllowUserToAddRows = false;
            this.dataGridViewBook.AllowUserToDeleteRows = false;
            this.dataGridViewBook.AllowUserToOrderColumns = true;
            this.dataGridViewBook.AllowUserToResizeColumns = false;
            this.dataGridViewBook.AllowUserToResizeRows = false;
            this.dataGridViewBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(127)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBook.ColumnHeadersHeight = 30;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBook.EnableHeadersVisualStyles = false;
            this.dataGridViewBook.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewBook.Location = new System.Drawing.Point(13, 196);
            this.dataGridViewBook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBook.MultiSelect = false;
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.ReadOnly = true;
            this.dataGridViewBook.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.dataGridViewBook.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBook.Size = new System.Drawing.Size(1290, 375);
            this.dataGridViewBook.TabIndex = 15;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(20, 96);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(260, 30);
            this.txt_Search.TabIndex = 8;
            // 
            // cB_Search_follow
            // 
            this.cB_Search_follow.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Tên sách",
            "Tên tác giả",
            "Nhà xuất bản",
            "Năm",
            "Thể loại"});
            this.cB_Search_follow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cB_Search_follow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Search_follow.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Search_follow.FormattingEnabled = true;
            this.cB_Search_follow.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tên tác giả",
            "Nhà xuất bản",
            "Năm xuất bản",
            "Thể loại"});
            this.cB_Search_follow.Location = new System.Drawing.Point(125, 48);
            this.cB_Search_follow.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Search_follow.Name = "cB_Search_follow";
            this.cB_Search_follow.Size = new System.Drawing.Size(155, 27);
            this.cB_Search_follow.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(316, 93);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(73, 33);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm theo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cB_Search_follow);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(508, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(408, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_EditBook
            // 
            this.btn_EditBook.Image = global::ClientApplication.Properties.Resources.icons8_check_book_48;
            this.btn_EditBook.Location = new System.Drawing.Point(273, 116);
            this.btn_EditBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditBook.Name = "btn_EditBook";
            this.btn_EditBook.Size = new System.Drawing.Size(80, 62);
            this.btn_EditBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_EditBook.TabIndex = 4;
            this.btn_EditBook.TabStop = false;
            this.btn_EditBook.Click += new System.EventHandler(this.btn_EditBook_Click);
            // 
            // btn_RemoveBook
            // 
            this.btn_RemoveBook.Image = global::ClientApplication.Properties.Resources.icons8_remove_book_48;
            this.btn_RemoveBook.Location = new System.Drawing.Point(167, 116);
            this.btn_RemoveBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoveBook.Name = "btn_RemoveBook";
            this.btn_RemoveBook.Size = new System.Drawing.Size(80, 62);
            this.btn_RemoveBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_RemoveBook.TabIndex = 3;
            this.btn_RemoveBook.TabStop = false;
            this.btn_RemoveBook.Click += new System.EventHandler(this.btn_RemoveBook_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Image = global::ClientApplication.Properties.Resources.icons8_add_book_48;
            this.btn_AddBook.Location = new System.Drawing.Point(61, 116);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(79, 62);
            this.btn_AddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AddBook.TabIndex = 2;
            this.btn_AddBook.TabStop = false;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(3, 3);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 23);
            this.notify.TabIndex = 16;
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.notify);
            this.panelNotify.Location = new System.Drawing.Point(475, 163);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(483, 26);
            this.panelNotify.TabIndex = 17;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(1176, 155);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 33);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Manage_Storage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1314, 575);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelNotify);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_EditBook);
            this.Controls.Add(this.btn_RemoveBook);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manage_Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manage_Storage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RemoveBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddBook)).EndInit();
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_AddBook;
        private System.Windows.Forms.PictureBox btn_RemoveBook;
        private System.Windows.Forms.PictureBox btn_EditBook;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cB_Search_follow;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label notify;
        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.Button buttonRefresh;
    }
}