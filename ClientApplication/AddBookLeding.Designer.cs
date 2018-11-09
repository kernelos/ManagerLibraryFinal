namespace ClientApplication
{
    partial class AddBookLeding
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBookOne = new System.Windows.Forms.PictureBox();
            this.addBookTwo = new System.Windows.Forms.PictureBox();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.Label();
            this.BookTwoName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lendDate = new System.Windows.Forms.DateTimePicker();
            this.BookOneName = new System.Windows.Forms.TextBox();
            this.textboxStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBookOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookTwo)).BeginInit();
            this.panelNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBookOne);
            this.groupBox1.Controls.Add(this.addBookTwo);
            this.groupBox1.Controls.Add(this.panelNotify);
            this.groupBox1.Controls.Add(this.BookTwoName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lendDate);
            this.groupBox1.Controls.Add(this.BookOneName);
            this.groupBox1.Controls.Add(this.textboxStudentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 252);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // addBookOne
            // 
            this.addBookOne.Image = global::ClientApplication.Properties.Resources.notebookAddItem;
            this.addBookOne.Location = new System.Drawing.Point(474, 63);
            this.addBookOne.Name = "addBookOne";
            this.addBookOne.Size = new System.Drawing.Size(40, 32);
            this.addBookOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBookOne.TabIndex = 39;
            this.addBookOne.TabStop = false;
            this.addBookOne.Click += new System.EventHandler(this.addBookOne_Click);
            // 
            // addBookTwo
            // 
            this.addBookTwo.Image = global::ClientApplication.Properties.Resources.notebookAddItem;
            this.addBookTwo.Location = new System.Drawing.Point(474, 103);
            this.addBookTwo.Name = "addBookTwo";
            this.addBookTwo.Size = new System.Drawing.Size(40, 32);
            this.addBookTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBookTwo.TabIndex = 38;
            this.addBookTwo.TabStop = false;
            this.addBookTwo.Click += new System.EventHandler(this.addBookTwo_Click);
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.notify);
            this.panelNotify.Location = new System.Drawing.Point(33, 196);
            this.panelNotify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(392, 35);
            this.panelNotify.TabIndex = 33;
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Dock = System.Windows.Forms.DockStyle.Left;
            this.notify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(0, 0);
            this.notify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 19);
            this.notify.TabIndex = 16;
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookTwoName
            // 
            this.BookTwoName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BookTwoName.Enabled = false;
            this.BookTwoName.Location = new System.Drawing.Point(131, 114);
            this.BookTwoName.Name = "BookTwoName";
            this.BookTwoName.Size = new System.Drawing.Size(338, 23);
            this.BookTwoName.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sách Mượn 2:";
            // 
            // lendDate
            // 
            this.lendDate.Enabled = false;
            this.lendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lendDate.Location = new System.Drawing.Point(131, 154);
            this.lendDate.MaxDate = new System.DateTime(2160, 12, 31, 0, 0, 0, 0);
            this.lendDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.lendDate.Name = "lendDate";
            this.lendDate.ShowUpDown = true;
            this.lendDate.Size = new System.Drawing.Size(145, 23);
            this.lendDate.TabIndex = 31;
            // 
            // BookOneName
            // 
            this.BookOneName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BookOneName.Enabled = false;
            this.BookOneName.Location = new System.Drawing.Point(131, 73);
            this.BookOneName.Name = "BookOneName";
            this.BookOneName.Size = new System.Drawing.Size(338, 23);
            this.BookOneName.TabIndex = 29;
            // 
            // textboxStudentID
            // 
            this.textboxStudentID.Location = new System.Drawing.Point(131, 32);
            this.textboxStudentID.Name = "textboxStudentID";
            this.textboxStudentID.Size = new System.Drawing.Size(133, 23);
            this.textboxStudentID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày Mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sách Mượn 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã số sinh viên:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(480, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 37);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 37);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApplication.Properties.Resources.lender;
            this.pictureBox1.Location = new System.Drawing.Point(170, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // AddBookLeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddBookLeding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lượt mượn sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBookOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookTwo)).EndInit();
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.Label notify;
        private System.Windows.Forms.TextBox BookTwoName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker lendDate;
        private System.Windows.Forms.TextBox BookOneName;
        private System.Windows.Forms.TextBox textboxStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox addBookTwo;
        private System.Windows.Forms.PictureBox addBookOne;
    }
}