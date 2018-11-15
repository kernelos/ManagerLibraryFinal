namespace ClientApplication
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.mnAccountBtn = new System.Windows.Forms.Button();
            this.BorrowingBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mnStoreBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnAccountBtn
            // 
            this.mnAccountBtn.FlatAppearance.BorderSize = 0;
            this.mnAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnAccountBtn.ForeColor = System.Drawing.Color.Black;
            this.mnAccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("mnAccountBtn.Image")));
            this.mnAccountBtn.Location = new System.Drawing.Point(176, 12);
            this.mnAccountBtn.Name = "mnAccountBtn";
            this.mnAccountBtn.Size = new System.Drawing.Size(161, 148);
            this.mnAccountBtn.TabIndex = 3;
            this.mnAccountBtn.Text = "Tài Khoản SV";
            this.mnAccountBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnAccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnAccountBtn.UseVisualStyleBackColor = true;
            this.mnAccountBtn.Click += new System.EventHandler(this.mnAccountBtn_Click);
            // 
            // BorrowingBtn
            // 
            this.BorrowingBtn.FlatAppearance.BorderSize = 0;
            this.BorrowingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowingBtn.ForeColor = System.Drawing.Color.Black;
            this.BorrowingBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowingBtn.Image")));
            this.BorrowingBtn.Location = new System.Drawing.Point(343, 12);
            this.BorrowingBtn.Name = "BorrowingBtn";
            this.BorrowingBtn.Size = new System.Drawing.Size(160, 148);
            this.BorrowingBtn.TabIndex = 4;
            this.BorrowingBtn.Text = "Mượn Trả";
            this.BorrowingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrowingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrowingBtn.UseVisualStyleBackColor = true;
            this.BorrowingBtn.Click += new System.EventHandler(this.BorrowingBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mnStoreBtn);
            this.panel3.Controls.Add(this.BorrowingBtn);
            this.panel3.Controls.Add(this.mnAccountBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 195);
            this.panel3.TabIndex = 1;
            // 
            // mnStoreBtn
            // 
            this.mnStoreBtn.FlatAppearance.BorderSize = 0;
            this.mnStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnStoreBtn.ForeColor = System.Drawing.Color.Black;
            this.mnStoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("mnStoreBtn.Image")));
            this.mnStoreBtn.Location = new System.Drawing.Point(12, 12);
            this.mnStoreBtn.Name = "mnStoreBtn";
            this.mnStoreBtn.Size = new System.Drawing.Size(158, 148);
            this.mnStoreBtn.TabIndex = 5;
            this.mnStoreBtn.Text = "Kho sách";
            this.mnStoreBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnStoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnStoreBtn.UseVisualStyleBackColor = true;
            this.mnStoreBtn.Click += new System.EventHandler(this.mnStoreBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 128);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CÁC CHỨC NĂNG DÀNH CHO THỦ THƯ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mnAccountBtn;
        private System.Windows.Forms.Button BorrowingBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mnStoreBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

