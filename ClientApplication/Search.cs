using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using System.Text.RegularExpressions;
namespace ClientApplication
{
 
    
    public partial class Search : Form
    {
        private DatabaseService Service;
        private string StudentId;
        private void dataSourceDefault()
        {
            dataGridViewBook.DataSource = Service.getDataContext().Books.Select(x => new
            {
                ID = x.Id,
                Author = x.Author.AuthorName,
                Title = x.Title,
                Publisher = x.Publisher.PublisherName,
                Category = x.Category.CategoryName,
                Quantity = x.Quantity,
                Year = x.PublishedYear,
                ISBN = x.ISBN,

            }).ToList();
            this.dataGridViewBook.Columns[0].HeaderText = "STT";
            this.dataGridViewBook.Columns[1].HeaderText = "Tác Giả";
            this.dataGridViewBook.Columns[2].HeaderText = "Tiêu Đề";
            this.dataGridViewBook.Columns[3].HeaderText = "Nhà Xuất Bản";
            this.dataGridViewBook.Columns[4].HeaderText = "Thể Loại";
            this.dataGridViewBook.Columns[5].HeaderText = "Số Lượng";
            this.dataGridViewBook.Columns[6].HeaderText = "Năm";
            this.dataGridViewBook.Columns[7].HeaderText = "ISBN";

            this.dataGridViewBook.Columns[0].Width = 50;
            this.dataGridViewBook.Columns[1].Width = 150;
            this.dataGridViewBook.Columns[2].Width = 250;
            this.dataGridViewBook.Columns[3].Width = 150;
            this.dataGridViewBook.Columns[5].Width = 100;
            this.dataGridViewBook.Columns[6].Width = 70;
            this.dataGridViewBook.Columns[7].Width = 120;

        }
        private void notifySet(string message)
        {
            notify.Text = message;
            notify.ForeColor = Color.IndianRed;
            panelNotify.BackColor = Color.LightPink;
        }
        private void notifyReset()
        {
            notify.Text = "";
            notify.ForeColor = this.BackColor;
            panelNotify.BackColor = this.BackColor;
        }
        public Search(string studentId)
        {
            InitializeComponent();
            StudentId = studentId;
            Service = new DatabaseService(StudentId);
            dataSourceDefault();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Search.Enabled = false;
            if (cB_Search_follow.SelectedItem == null || String.IsNullOrEmpty(txt_Search.Text))
            {
                notifySet("Chọn và Nhập đầy đủ thông tin trước khi bấm tìm kiếm.");
                btn_Search.Enabled = true;
                return;
            }
            notifyReset();
            var data = Service.getDataContext().Books.Select(x => new
            {
                ID = x.Id,
                Author = x.Author.AuthorName,
                Title = x.Title,
                Publisher = x.Publisher.PublisherName,
                Category = x.Category.CategoryName,
                Quantity = x.Quantity,
                Year = x.PublishedYear,
                ISBN = x.ISBN,
            });
            switch (cB_Search_follow.SelectedIndex)
            {
                case 0:
                    dataGridViewBook.DataSource = data.Where(x => x.ISBN == txt_Search.Text).ToList();
                    break;
                case 1:
                    dataGridViewBook.DataSource = data.Where(x => x.Title.ToLower() == txt_Search.Text.ToLower()).ToList();
                    break;
                case 2:
                    dataGridViewBook.DataSource = data.Where(x => x.Author.ToLower() == txt_Search.Text.ToLower()).ToList();
                    break;
                case 3:
                    dataGridViewBook.DataSource = data.Where(x => x.Publisher.ToLower() == txt_Search.Text.ToLower()).ToList();
                    break;
                case 4:
                    if (!Regex.IsMatch(txt_Search.Text, "^[0-9]{4,4}$"))
                    {
                        notifySet("Nhập Năm không hợp lệ.");
                        btn_Search.Enabled = true;
                        return;
                    }

                    int year = int.Parse(txt_Search.Text);
                    dataGridViewBook.DataSource = data.Where(x => x.Year == year).ToList();
                    break;
                case 5:
                    dataGridViewBook.DataSource = data.Where(x => x.Category.ToLower() == txt_Search.Text.ToLower()).ToList();
                    break;
            }
            btn_Search.Enabled = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataSourceDefault();
            notifyReset();
            btn_Search.Enabled = true;
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StudentUI newUi = new StudentUI(StudentId);
            newUi.ShowDialog();
        }

    }
}
