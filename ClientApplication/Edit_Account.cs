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
    public partial class Edit_Account : Form
    {
        String Username;
        DatabaseService Service;
        int CurrentId;
        string oldPass;
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
        public Edit_Account(int id, string username)
        {
            InitializeComponent();
            Username = username;
            Service = new DatabaseService(username);
            CurrentId = id;
            Student student = Service.getDataContext().Students.FirstOrDefault(x => x.Id == CurrentId);
            txt_Name.Text = student.StudentName;
            txt_Personalid.Text = student.PersonalId;
            txt_StudenId.Text = student.StudentId;
            oldPass = student.PasswordStr;
            if (student.Birthday != null)
            {
                txt_Date.Value = (DateTime)student.Birthday;
            }     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                Service.StudentEntity.Update(toEdit);
                this.Hide();
            }
            catch (Exception)
            {
                notify.BackColor = Color.LightPink;
                notify.Text = "Bạn nhập không đúng định dạng";
                panelNotify.ForeColor = Color.IndianRed;
            }
        }
    }
}
