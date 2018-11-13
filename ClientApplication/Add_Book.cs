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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Service.AddBookToLibrary(txtName.Text, txt_quantity.Text, txt_ISBN.Text, txtYear.Text
                    , richTextDecription.Text, txtAuthor.Text, txtPublisher.Text, txtCategory.Text);
                this.Hide();
            }
            catch (Exception)
            {
                notify.BackColor = Color.LightPink;
                labelNotify.Text = "Bạn nhập không đúng định dạng thông tin.\n Vui lòng nhập lại, hoặc bấm Hủy.";
                labelNotify.ForeColor = Color.IndianRed;
            }
        }
    }
}
