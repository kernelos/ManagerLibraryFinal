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
using System.Threading;
namespace ClientApplication
{
    public partial class Edit_Book_Information : Form
    {
        DatabaseService Service;
        int idBook;
        public Edit_Book_Information(string username, int idEdit)
        {
            InitializeComponent();
            Service = new DatabaseService(username);
            idBook = idEdit;
            using (var dataContext = Service.getDataContext())
            {
                Book book = dataContext.Books.FirstOrDefault(x => x.Id == idEdit);
                if (book == null)
                    throw new ArgumentNullException(nameof(book));
                txt_ISBN.Text = book.ISBN;
                if (book.Author != null)
                    txtAuthor.Text = book.Author.AuthorName;
                txtName.Text = book.Title;
                if (book.Publisher != null)
                    txtPublisher.Text = book.Publisher.PublisherName;
                txtYear.Text = book.PublishedYear.ToString();
                if (book.Category != null)
                    txtCategory.Text = book.Category.CategoryName;
                richTextDecription.Text = book.BookDecription;
                txt_quantity.Text = book.Quantity.ToString();
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            notify.BackColor = this.BackColor;
            labelNotify.Text = "";
            labelNotify.ForeColor = this.BackColor;
            try
            {
                Service.UpdateBook(idBook, txtName.Text, txt_quantity.Text,
                txt_ISBN.Text, txtYear.Text, richTextDecription.Text,
                txtAuthor.Text, txtPublisher.Text, txtCategory.Text);
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
