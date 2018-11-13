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
using DB;
namespace ClientApplication
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_StudenId.Text))
            {
                notifySet("Hãy nhập mã số sinh viên");
                return;
            }
            notifyReset();
            using(var dataContext = Program.Service.getDataContext())
            {
                Student student = dataContext.Students.FirstOrDefault(x => x.StudentId == txt_StudenId.Text);
                if (student != null)
                {
                    notifySet("Tài khoản có MSSV đã tồn tại.");
                    return;
                }   
            }
            try
            {
                Student newStudent = new Student()
                {
                    StudentId = txt_StudenId.Text,
                    StudentName = txt_Name.Text,
                    PasswordStr = txt_Password.Text,
                    PersonalId = String.IsNullOrEmpty(txt_Personalid.Text)?null:txt_Personalid.Text,
                    Birthday = txt_Date.Value.Date
                };
                Program.Service.StudentEntity.Add(newStudent);
                this.Hide();
            }
            catch (Exception)
            {
                notifySet("Nhập không đúng định dạng.");
            }
        }
    }
}
