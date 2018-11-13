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
    public partial class AddBookLeding : Form
    {
        private int IdBookOne = -1;
        private int? IdBookTwo = null;
        private Search bookData;
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
        public AddBookLeding()
        {
            InitializeComponent();
            bookData = new Search();
        }

        private void addBookOne_Click(object sender, EventArgs e)
        {
            bookData.ShowDialog();
            IdBookOne = bookData.IDCurrent;
            if (IdBookOne <0)
                return;
            BookOneName.Text = Program.Service.getDataContext().Books.FirstOrDefault
                (x => x.Id == IdBookOne).Title;
        }

        private void addBookTwo_Click(object sender, EventArgs e)
        {
            if (IdBookOne < 0)
                return;
            bookData.ShowDialog();
            if(bookData.IDCurrent == IdBookOne)
            {
                notifySet("Không được mượn 2 sách trùng nhau");
                return;
            }
            notifyReset();
            IdBookTwo = bookData.IDCurrent;
            BookTwoName.Text = Program.Service.getDataContext().Books.FirstOrDefault
                (x => x.Id == IdBookTwo).Title;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textboxStudentID.Text))
            {
                notifySet("Vui lòng điền Mã Số Sinh Viên");
                return;
            }
            if (IdBookOne < 0)
            {
                notifySet("Vui lòng chọn ít nhất một cuốn sách để mượn");
                return;
            }
            notifyReset();
            using (var dataContext = Program.Service.getDataContext())
            {
                Student student = dataContext.Students.FirstOrDefault(x => x.StudentId == textboxStudentID.Text);
                if (student == null)
                {
                    notifySet("Sinh viên chưa đăng kí sử dụng thư viện");
                    return;
                }
                
                BookLending bookLending = new BookLending()
                {
                    StudentId = student.Id,
                    BooIdOne = IdBookOne,
                    BookIdTwo = IdBookTwo,
                    LendingManagerId = dataContext.LibManagers.FirstOrDefault
                                        (x => x.Username.ToLower() == Program.Username.ToLower()).Id,
                    LendingDay = lendDate.Value.Date,
                    IsReturn = false
                    
                };
                Program.Service.AddBookLending(bookLending);
                this.Hide();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
