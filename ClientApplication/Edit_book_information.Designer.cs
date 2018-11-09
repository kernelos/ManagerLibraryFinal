namespace ClientApplication
{
    partial class Edit_Book_Information
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notify = new System.Windows.Forms.Panel();
            this.labelNotify = new System.Windows.Forms.Label();
            this.richTextDecription = new System.Windows.Forms.RichTextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.lb_Year = new System.Windows.Forms.Label();
            this.lb_Publisher = new System.Windows.Forms.Label();
            this.lb_Author = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(467, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(562, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 37);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApplication.Properties.Resources.icons8_check_book_96;
            this.pictureBox1.Location = new System.Drawing.Point(279, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notify);
            this.groupBox1.Controls.Add(this.richTextDecription);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txt_ISBN);
            this.groupBox1.Controls.Add(this.lb_Year);
            this.groupBox1.Controls.Add(this.lb_Publisher);
            this.groupBox1.Controls.Add(this.lb_Author);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.lb_ID);
            this.groupBox1.Location = new System.Drawing.Point(5, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 332);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // notify
            // 
            this.notify.Controls.Add(this.labelNotify);
            this.notify.Location = new System.Drawing.Point(209, 267);
            this.notify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(407, 58);
            this.notify.TabIndex = 36;
            // 
            // labelNotify
            // 
            this.labelNotify.AutoSize = true;
            this.labelNotify.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotify.Location = new System.Drawing.Point(53, 11);
            this.labelNotify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotify.Name = "labelNotify";
            this.labelNotify.Size = new System.Drawing.Size(0, 17);
            this.labelNotify.TabIndex = 0;
            // 
            // richTextDecription
            // 
            this.richTextDecription.Location = new System.Drawing.Point(86, 128);
            this.richTextDecription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextDecription.Name = "richTextDecription";
            this.richTextDecription.Size = new System.Drawing.Size(531, 122);
            this.richTextDecription.TabIndex = 30;
            this.richTextDecription.Text = "";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(86, 269);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(119, 20);
            this.txt_quantity.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mô tả";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(499, 10);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(119, 20);
            this.txtCategory.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thể loại";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(499, 80);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(119, 20);
            this.txtYear.TabIndex = 29;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(86, 79);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(268, 20);
            this.txtPublisher.TabIndex = 28;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(499, 46);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(119, 20);
            this.txtAuthor.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 26;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ISBN.Location = new System.Drawing.Point(86, 8);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(268, 20);
            this.txt_ISBN.TabIndex = 24;
            // 
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.Location = new System.Drawing.Point(416, 83);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(73, 13);
            this.lb_Year.TabIndex = 23;
            this.lb_Year.Text = "Năm xuất bản";
            // 
            // lb_Publisher
            // 
            this.lb_Publisher.AutoSize = true;
            this.lb_Publisher.Location = new System.Drawing.Point(4, 82);
            this.lb_Publisher.Name = "lb_Publisher";
            this.lb_Publisher.Size = new System.Drawing.Size(71, 13);
            this.lb_Publisher.TabIndex = 22;
            this.lb_Publisher.Text = "Nhà xuất bản";
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Location = new System.Drawing.Point(416, 49);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(43, 13);
            this.lb_Author.TabIndex = 21;
            this.lb_Author.Text = "Tác giả";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(4, 48);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(26, 13);
            this.lb_Name.TabIndex = 20;
            this.lb_Name.Text = "Tên";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(4, 12);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(48, 13);
            this.lb_ID.TabIndex = 19;
            this.lb_ID.Text = "Mã sách";
            // 
            // Edit_Book_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Book_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.notify.ResumeLayout(false);
            this.notify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.Label lb_Publisher;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.RichTextBox richTextDecription;
        private System.Windows.Forms.Panel notify;
        private System.Windows.Forms.Label labelNotify;
    }
}