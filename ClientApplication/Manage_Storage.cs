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
using System.Threading;
using DB;
using System.Text.RegularExpressions;
namespace ClientApplication
{
    public partial class Manage_Storage : Form
    {
        private int IDCurrent = -1;
        public Manage_Storage()
        {
            InitializeComponent();
            dataSourceDefault();
        }
        private void dataSourceDefault()
        {
            dataGridViewBook.DataSource = Program.Service.getDataContext().Books.Select(x => new
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
            this.dataGridViewBook.Columns[1].Width = 200;
            this.dataGridViewBook.Columns[2].Width = 400;
            this.dataGridViewBook.Columns[3].Width = 200;
            this.dataGridViewBook.Columns[5].Width = 100;
            this.dataGridViewBook.Columns[6].Width = 70;
            this.dataGridViewBook.Columns[7].Width = 150;

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
        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            if (IDCurrent == -1)//gia tri mac dinh
            {
                notifySet("Hãy chọn sách để chỉnh sửa ở bảng phía dưới.");
                return;
            }
            Edit_Book_Information EditBook = new Edit_Book_Information(IDCurrent);
            EditBook.Show();
            notifySet("Thông tin chưa được cập nhật. Vui lòng bấm \"Làm mới\"");
            btn_Search.Enabled = true;
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            Add_Book form = new Add_Book();
            form.Show();
            notifySet("Thông tin chưa được cập nhật. Vui lòng bấm \"Làm mới\"");
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
            var data = Program.Service.getDataContext().Books.Select(x => new
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

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[index];
                IDCurrent = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void btn_RemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                notifyReset();
                if (IDCurrent == -1)//gia tri mac dinh
                {
                    notifySet("Hãy chọn sách để xóa ở bảng phía dưới.");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc sẽ xóa thông tin sách này", "Xác Minh",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.Service.DeleteBook(IDCurrent);
                    dataSourceDefault();
                }

            }
            catch (Exception E)
            {
                notifySet("Có sự cố xảy xa, vui lòng thử lại.");
            }
        }


        private void Manage_Storage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            UI newUi = new UI();
            newUi.ShowDialog();
        }
    }
}
