using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Services;
using DB;
namespace ClientApplication
{
    public partial class Borrowing : Form
    {
        private string Username;
        private DatabaseService Service;
        private int CurrentId = -1;
        private string StudentId;
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
        private void loadDataDefault()
        {
            dataGridViewBookLeding.DataSource = Service.getDataContext().BookLendings.Select(x => new
            {
                ID = x.Id,
                StudentId = x.Student.StudentId,
                Studentname = x.Student.StudentName,
                Book = x.Book.Title,
                Book2 = x.Book1 == null ? null : x.Book1.Title,
                Date1 = x.LendingDay,
                IsReturn = x.IsReturn == true ? "Đã Trả" : "Chưa Trả",
                date2 = x.ReturnDay,
                ManagerLeding = x.LibManager.ManagerName,
                ManagerReturn = x.LibManager1 == null ? null : x.LibManager1.ManagerName

            }).ToList();

        }
        public Borrowing(string username)
        {
            InitializeComponent();
            Username = username;
            Service = new DatabaseService(Username);
            loadDataDefault();

            dataGridViewBookLeding.Columns[0].HeaderText = "STT";
            dataGridViewBookLeding.Columns[1].HeaderText = "MSSV";
            dataGridViewBookLeding.Columns[2].HeaderText = "Họ Và Tên";
            dataGridViewBookLeding.Columns[3].HeaderText = "Sách 1";
            dataGridViewBookLeding.Columns[4].HeaderText = "Sách 2";
            dataGridViewBookLeding.Columns[5].HeaderText = "Ngày Mượn";
            dataGridViewBookLeding.Columns[6].HeaderText = "Tình Trạng";
            dataGridViewBookLeding.Columns[7].HeaderText = "Ngày Trả";
            dataGridViewBookLeding.Columns[8].HeaderText = "Thủ Thư Mượn";
            dataGridViewBookLeding.Columns[9].HeaderText = "Thủ Thư Trả";


            dataGridViewBookLeding.Columns[0].Width = 50;
            dataGridViewBookLeding.Columns[1].Width = 70;
            dataGridViewBookLeding.Columns[2].Width = 200;
            dataGridViewBookLeding.Columns[3].Width = 200;
            dataGridViewBookLeding.Columns[4].Width = 200;
            dataGridViewBookLeding.Columns[5].Width = 100;
            dataGridViewBookLeding.Columns[6].Width = 100;
            dataGridViewBookLeding.Columns[7].Width = 100;
            dataGridViewBookLeding.Columns[8].Width = 150;
            dataGridViewBookLeding.Columns[9].Width = 150;
        }

        private void buttonAddBookLend_Click(object sender, EventArgs e)
        {
            notifySet("Thông tin chưa được cập nhật. Vui lòng bấm \"Làm mới\"");
            AddBookLeding addBookLeding = new AddBookLeding(Username);
            addBookLeding.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadDataDefault();
            notifyReset();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            if (CurrentId < 0)
            {
                notifySet("Chọn Sinh Viên Trả Sách Trước Khi Bấm Trả");
                return;
            }
            notifyReset();
            try
            {
                int idLibManager = Service.getDataContext().LibManagers.FirstOrDefault(x => x.Username == Username).Id;
                int idStudent = Service.getDataContext().Students.FirstOrDefault(x => x.StudentId == StudentId).Id;
                if (MessageBox.Show("Thực hiện trả sách cho sinh viên hiện tại", "Xác Thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Service.ReturnBookLending(idStudent, idLibManager);
                    loadDataDefault();
                }
            }
            catch (Exception)
            {
                notifySet("Xảy Ra Lỗi Vui Lòng Thử Lại");
            }


        }

        private void dataGridViewBookLeding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridViewBookLeding.Rows[index];
                CurrentId = int.Parse(row.Cells[0].Value.ToString());
                StudentId = row.Cells[1].Value.ToString();
            }
        }

        private void ButtonReNewBook_Click(object sender, EventArgs e)
        {
            if (CurrentId < 0)
            {
                notifySet("Chọn Sinh Viên Trả Sách Trước Khi Bấm Trả");
                return;
            }
            notifyReset();
            try
            {
                int idLibManager = Service.getDataContext().LibManagers.FirstOrDefault(x => x.Username == Username).Id;
                int idStudent = Service.getDataContext().Students.FirstOrDefault(x => x.StudentId == StudentId).Id;
                if (MessageBox.Show("Thực hiện gia hạn sách cho sinh viên hiện tại", "Xác Thực", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Service.RenewBookLending(idStudent, idLibManager);
                    loadDataDefault();
                }
            }
            catch (Exception)
            {
                notifySet("Xảy Ra Lỗi Vui Lòng Thử Lại");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Search.Enabled = false;
            if (String.IsNullOrEmpty(textboxSearch.Text)
                || comboBoxSetting.SelectedItem == null)
            {
                notifySet("Chọn và Nhập đầy đủ thông tin trước khi bấm tìm kiếm.");
                btn_Search.Enabled = true;
                return;
            }
            notifyReset();
            var data = Service.getDataContext().BookLendings.Select(x => new
            {
                ID = x.Id,
                StudentId = x.Student.StudentId,
                Studentname = x.Student.StudentName,
                Book = x.Book.Title,
                Book2 = x.Book1 == null ? null : x.Book1.Title,
                Date1 = x.LendingDay,
                IsReturn = x.IsReturn == true ? "Đã Trả" : "Chưa Trả",
                date2 = x.ReturnDay,
                ManagerLeding = x.LibManager.ManagerName,
                ManagerReturn = x.LibManager1 == null ? null : x.LibManager1.ManagerName
            });
            switch (comboBoxSetting.SelectedIndex)
            {
                case 0:
                    dataGridViewBookLeding.DataSource = data.Where(x => x.IsReturn == "Đã Trả" && x.StudentId == textboxSearch.Text).ToList();
                    break;
                case 1:
                    dataGridViewBookLeding.DataSource = data.Where(x => x.IsReturn == "Chưa Trả" && x.StudentId == textboxSearch.Text).ToList();
                    break;
                case 2:
                    dataGridViewBookLeding.DataSource = data.Where(x=>x.StudentId == textboxSearch.Text).ToList();
                    break;
            }
            btn_Search.Enabled = true;
        }

        private void Borrowing_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            UI newUi = new UI(Username);
            newUi.ShowDialog();
        }
    }
}
