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
    public partial class PhoneBookForm : Form
    {
        public PhoneBookForm()
        {
            InitializeComponent();
        }

        private void PhoneBookForm_Load(object sender, EventArgs e)
        {
            this.phonebookTableAdapter.Fill(this.phoneBookDataSet.Phonebook);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tsb_saveContact_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phonebookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneBookDataSet);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string contactLastname = toolStripTextBox1.Text.Trim();
            try
            {

                phonebookTableAdapter.FillByContactLastName(phoneBookDataSet.Phonebook, contactLastname);
                if (phonebookBindingSource.Count == 0)
                {
                    MessageBox.Show("No customers records found for " + contactLastname);
                    phonebookTableAdapter.Fill(phoneBookDataSet.Phonebook);


                    toolStripButton2_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DisplayRecords form = new DisplayRecords();
            form.Show();
            this.phonebookTableAdapter.Fill(this.phoneBookDataSet.Phonebook);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void tsb_search_Click(object sender, EventArgs e)
        {
            string contactLastname = toolStripTextBox1.Text.Trim();
            try
            {

                phonebookTableAdapter.FillByContactLastName(phoneBookDataSet.Phonebook, contactLastname);
                if (phonebookBindingSource.Count == 0)
                {
                    MessageBox.Show("No customers records found for " + contactLastname);
                    phonebookTableAdapter.Fill(phoneBookDataSet.Phonebook);


                    toolStripButton2_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}



