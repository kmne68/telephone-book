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
    public partial class DisplayRecords : Form
    {
        public DisplayRecords()
        {
            InitializeComponent();
        }

        private void DisplayRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneBookDataSet.Phonebook' table. You can move, or remove it, as needed.
            this.phonebookTableAdapter.Fill(this.phoneBookDataSet.Phonebook);

        }
    }
}
