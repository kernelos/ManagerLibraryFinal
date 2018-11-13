using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using Services;
namespace ClientApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Program.Username = txtUsername.Text;
            if (String.IsNullOrEmpty(txtUsername.Text) ||
                String.IsNullOrEmpty(txtPassword.PasswordChar.ToString()) ||
                cBchedo.SelectedItem == null)
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Các Thông Tin", "Cảnh Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
                
            Role role = (Role)cBchedo.SelectedIndex;
            
            try
            {
                Program.Service = new DatabaseService(Program.Username);
                if (role == Role.ManagerRole)
                {
                    if (Program.Service.IsFirstLoginManager()) {
                        MessageBox.Show("Đây là lần đăng nhập đầu tiên của bạn," +
                            " chúng tôi sẽ tạo tài khoản theo username và password bạn đã cung cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
          
                }
                if(Program.Service.Authenticate(txtUsername.Text, txtPassword.Text, role))
                {
                    this.Hide();
                    if (role == Role.ManagerRole)
                    {
                        UI ui = new UI();
                        ui.ShowDialog();
                    }
                    else if(role == Role.StudentRole)
                    {
                        StudentUI ui = new StudentUI();
                        ui.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Lỗi Xác Thực", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
                
            }
            catch(Exception E)
            {
                MessageBox.Show("Thông tin bạn điền không đúng định dạng" , "Lỗi Xác Thực", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
