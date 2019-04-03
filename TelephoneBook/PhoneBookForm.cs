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

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tsb_saveContact_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.phoneBookDataSet1);
        }
    }
}


/*
namespace SQLServerDemo2
{
    public partial class Form1 : Form
    {

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calicuttDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calicuttDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calicuttDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calicuttDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calicuttDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.calicuttDataSet.Customers);

        }

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
