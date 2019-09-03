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
        List<Customer> customers = null;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer customer = addCustomerForm.GetNewCustomer();

            if(customer!=null)
            {
                customers.Add(customer);
                CustomerDb.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i!=-1)
            {
                Customer customer = customers[i];
                string message = "Are you sure youn want to delete " + customer.FirstName + " " + customer.Lastname + "?";
                DialogResult button = MessageBox.Show(message, "confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    CustomerDb.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDb.GetCustomers();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDispayText());
            }
        }
    }
}
