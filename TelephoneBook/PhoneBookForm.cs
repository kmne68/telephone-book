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
           // this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);
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

        /*
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calicuttDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);
        }
        */

        /*
                private void toolStripButton1_Click(object sender, EventArgs e)
                {
                    try
                    {
                        int customerID = Convert.ToInt32(toolStripTextBox1.Text.Trim());
                        customersTableAdapter.FillByCustomerID(calicuttDataSet.Customers, customerID);
                        if (customersBindingSource.Count == 0)
                        {
                            MessageBox.Show("No records found for customer " + customerID.ToString());
                            //You can use either approach to requery the database to re-populate the grid
                            //Option #1
                            //this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);

                            //Option #2
                            this.toolStripButton2_Click(null, null);
                        }
                    }
                    catch (Exception ex)
                    {


                    }

                }
        */



    }
}


/*
namespace SQLServerDemo2
{
    public partial class Form1 : Form
    {

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(toolStripTextBox1.Text.Trim());
                customersTableAdapter.FillByCustomerID(calicuttDataSet.Customers, customerID);
                if (customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No records found for customer " + customerID.ToString());
                    //You can use either approach to requery the database to re-populate the grid
                    //Option #1
                    //this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);

                    //Option #2
                    this.toolStripButton2_Click(null, null);
                }
            }
            catch (Exception ex)
            {


            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calicuttDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();

            myForm = null;
        }
    }
} */
