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
namespace ClientApplication
{
    public partial class Manage_Account : Form
    {
        private string Username;
        DatabaseService Service;
        int CurrentID = -1;
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
        public Manage_Account(string username)
        {
            InitializeComponent();
            Username = username;
            Service = new DatabaseService(Username);
            loadDataDefault();
            dataGridViewStudent.Columns[0].HeaderText = "STT";
            dataGridViewStudent.Columns[1].HeaderText = "MSSV";
            dataGridViewStudent.Columns[2].HeaderText = "Họ Và Tên";
            dataGridViewStudent.Columns[3].HeaderText = "Ngày Sinh";
            dataGridViewStudent.Columns[4].HeaderText = "Số CMND";

            dataGridViewStudent.Columns[0].Width = 70;
            dataGridViewStudent.Columns[1].Width = 120;
            dataGridViewStudent.Columns[2].Width = 200;
            dataGridViewStudent.Columns[3].Width = 130;
            dataGridViewStudent.Columns[4].Width = 120;
        }

        private void loadDataDefault()
        {
            dataGridViewStudent.DataSource = Service.getDataContext().Students.Select(x => new
            {
                ID = x.Id,
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Birthday = x.Birthday,
                PersonalId = x.PersonalId
            }).ToList();
        }
        private void btn_Add_Account_Click(object sender, EventArgs e)
        {
            Add_Account Add_Account_form = new Add_Account(Username);
            Add_Account_form.Show();
            notifySet("Thông tin chưa được cập nhật.Vui lòng bấm \"Làm mới\"");
        }

        private void btn_Edit_Account_Click(object sender, EventArgs e)
        {
            if (CurrentID < 0)
            {
                notifySet("Hãy chọn tài khoản cần chỉnh sửa");
                return;
            }
            notifyReset();
            Edit_Account form = new Edit_Account(CurrentID, Username);
            form.Show();
            notifySet("Thông tin chưa được cập nhật.Vui lòng bấm \"Làm mới\"");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadDataDefault();
            notifyReset();
        }

        private void btn_Remove_Account_Click(object sender, EventArgs e)
        {
            if (CurrentID < 0)
            {
                notifySet("Hãy chọn tài khoản cần xóa");
                return;
            }
            notifyReset();
            if (MessageBox.Show("Bạn có chắc sẽ xóa tài khoản này", "Xác Minh",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Service.StudentEntity.Delete(CurrentID);
                    loadDataDefault();
                }
                catch (Exception)
                {
                    notifySet("Thao tác lỗi, vui lòng thử lại.");
                }

            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow rows = dataGridViewStudent.Rows[index];
                CurrentID = int.Parse(rows.Cells[0].Value.ToString());
            }
        }

        //Phần tiền kiếm
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cB_Search_follow.SelectedItem == null ||
                String.IsNullOrEmpty(txt_Search.Text))
            {
                notifySet("Vui lòng điền đầy đủ thông tin trước khi bấm Tìm");
                return;
            }
            notifyReset();
            var data = Service.getDataContext().Students.Select(x => new {
                ID = x.Id,
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Birthday = x.Birthday,
                PersonalId = x.PersonalId
            });
            switch (cB_Search_follow.SelectedIndex)
            {
                case 0://tìm theo mssv
                    dataGridViewStudent.DataSource = data.Where(x => x.StudentId == txt_Search.Text).ToList();
                    break;
                case 1:
                    dataGridViewStudent.DataSource = data.Where(x => x.StudentName.ToLower() == txt_Search.Text.ToLower()).ToList();
                    break;
                case 2:
                    dataGridViewStudent.DataSource = data.Where(x => x.PersonalId == txt_Search.Text).ToList();
                    break;
            }
        }

        private void Manage_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            UI newUi = new UI(Username);
            newUi.ShowDialog();
        }
    }
}
