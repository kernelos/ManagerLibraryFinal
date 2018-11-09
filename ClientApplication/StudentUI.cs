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
    public partial class StudentUI : Form
    {
        string student;
        public StudentUI(string StudenID)
        {
            InitializeComponent();
            student = StudenID;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search(student);
            search.ShowDialog();
        }

        private void mnAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile stuProfile = new Profile(student);
            stuProfile.ShowDialog();
        }

        private void StudentUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
