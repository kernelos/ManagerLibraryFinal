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
using DB;
namespace ClientApplication
{
    public partial class Profile : Form
    {
        private int CurrentId;
        private String oldPass;
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
            dataGridViewBookLeding.DataSource = Program.Service.getDataContext().BookLendings.Where(x => x.StudentId == CurrentId).Select(x => new
            {
                Book = x.Book.Title,
                Book2 = x.Book1 == null ? null : x.Book1.Title,
                Date1 = x.LendingDay,
                IsReturn = x.IsReturn == true ? "Đã Trả" : "Chưa Trả",
                date2 = x.ReturnDay,

            }).ToList();
        }
        public Profile()
        {
            InitializeComponent();
            Student student = Program.Service.getDataContext().Students.FirstOrDefault(x => x.StudentId == Program.Username);
            CurrentId = student.Id;
            loadDataDefault();
            oldPass = student.PasswordStr;
            txt_Name.Text = student.StudentName;
            txt_StudenId.Text = student.StudentId;
            txt_Personalid.Text = student.PersonalId;
            txt_Date.Value = (DateTime)student.Birthday;
            txt_Name.Enabled = false;
            txt_StudenId.Enabled = false;
            txt_Personalid.Enabled = false;
            txt_Date.Enabled = false;
            txt_Password.Enabled =false;
            dataGridViewBookLeding.Columns[0].HeaderText = "Sách 1";
            dataGridViewBookLeding.Columns[1].HeaderText = "Sách 2";
            dataGridViewBookLeding.Columns[2].HeaderText = "Ngày Mượn";
            dataGridViewBookLeding.Columns[3].HeaderText = "Tình Trạng";
            dataGridViewBookLeding.Columns[4].HeaderText = "Ngày Trả";

            dataGridViewBookLeding.Columns[0].Width = 200;
            dataGridViewBookLeding.Columns[1].Width = 200;
            dataGridViewBookLeding.Columns[2].Width = 100;
            dataGridViewBookLeding.Columns[3].Width = 100;
            dataGridViewBookLeding.Columns[4].Width = 90;

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            txt_Name.Enabled = true;
            txt_StudenId.Enabled = true;
            txt_Personalid.Enabled = true;
            txt_Date.Enabled = true;
            txt_Password.Enabled = true;
            buttonSave.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            notify.Text = "";
            notify.ForeColor = this.BackColor;
            panelNotify.BackColor = this.BackColor;
            try
            {
                Student toEdit = new Student()
                {
                    Id = CurrentId,
                    PersonalId = txt_Personalid.Text,
                    Birthday = txt_Date.Value.Date,
                    StudentName = txt_Name.Text,
                    PasswordStr = string.IsNullOrEmpty(txt_Password.Text) ? oldPass : txt_Password.Text,
                    StudentId = txt_StudenId.Text
                };
                Program.Service.StudentEntity.Update(toEdit);
                MessageBox.Show("Tài Khoản đã được sửa đổi.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Visible = false;
                txt_Name.Enabled = false;
                txt_StudenId.Enabled = false;
                txt_Personalid.Enabled = false;
                txt_Date.Enabled = false;
                txt_Password.Enabled = false;
                notifySet("Bấm nút lọc để cập nhật hiển thị thông tin mượn.");
            }
            catch (Exception)
            {
                notify.BackColor = Color.LightPink;
                notify.Text = "Bạn nhập không đúng định dạng";
                panelNotify.ForeColor = Color.IndianRed;
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (comboBoxSetting.SelectedItem == null)
            {
                notifySet("Vui lòng chọn đế độ lọc");
                return;
            }
            notifyReset();
            var data = Program.Service.getDataContext().BookLendings.Where(x => x.StudentId == CurrentId).Select(x => new
            {
                Book = x.Book.Title,
                Book2 = x.Book1 == null ? null : x.Book1.Title,
                Date1 = x.LendingDay,
                IsReturn = x.IsReturn == true ? "Đã Trả" : "Chưa Trả",
                date2 = x.ReturnDay,
            });
            switch (comboBoxSetting.SelectedIndex)
            {
                case 0:
                    dataGridViewBookLeding.DataSource = data.Where(x => x.IsReturn == "Đã Trả").ToList();
                    break;
                case 1:
                    dataGridViewBookLeding.DataSource = data.Where(x => x.IsReturn == "Chưa Trả").ToList();
                    break;
                case 2:
                    dataGridViewBookLeding.DataSource = data.ToList();
                    break;
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StudentUI newUI = new StudentUI();
            newUI.ShowDialog();
        }
    }
}
