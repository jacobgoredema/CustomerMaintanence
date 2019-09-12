using CustomerMaintenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {       
        public frmCustomers()
        {
            InitializeComponent();
        }

        private CustomerList customers = new CustomerList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer;
            frmAddWholesaleCustomer addWholesaleCustomer = new frmAddWholesaleCustomer();
            customer = addWholesaleCustomer.GetNewCustomer();

            if(customer!=null)
            {
                customers.Add(customer);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i!=-1)
            {
                Customer customer = (Customer)customers[i];
                string message = "Are you sure youn want to delete " + customer.FirstName + " " + customer.Lastname + "?";
                DialogResult button = MessageBox.Show(message, "confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    customers -= customer;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers.Changed += new CustomerList.ChangeHandler(HandleChange);            

            customers.Fill();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDispayText());
            }
        }

        private void btnAddRetail_Click(object sender, EventArgs e)
        {
            Customer customer;
            frmAddRetailCustomer addRetailForm = new frmAddRetailCustomer();
            customer = addRetailForm.GetNewCustomer();

            if (customer!=null)
            {
                customers.Add(customer);
            }
        }

        private void HandleChange(CustomerList list)
        {
            customers.Save();
            FillCustomerListBox();
        }
    }
}
