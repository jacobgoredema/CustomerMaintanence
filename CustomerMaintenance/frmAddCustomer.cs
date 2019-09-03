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
    public partial class frmAddCustomer : Form
    {
        private Customer customer = null;

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            ShowDialog();
            return customer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstname.Text, txtLastname.Text, txtEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstname) && 
                Validator.IsPresent(txtLastname) &&
                Validator.IsPresent(txtEmail) && 
                Validator.IsValidEmail(txtEmail);
        }
    }
}
