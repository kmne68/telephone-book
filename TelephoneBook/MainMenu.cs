using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void phonebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneBookForm form = new PhoneBookForm();
            form.Show();
        }

        private void microsoftReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
