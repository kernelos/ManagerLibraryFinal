using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class UI : Form
    {
        string librarian;
        public UI(string username)
        {
            InitializeComponent();
            librarian = username;
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mnStoreBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Storage mnStore = new Manage_Storage(librarian);
            mnStore.ShowDialog();
        }

        private void mnAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Account mnAccount = new Manage_Account(librarian);
            mnAccount.ShowDialog();
        }

        private void BorrowingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrowing borrowing = new Borrowing(librarian);
            borrowing.ShowDialog();
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }


    }
}
