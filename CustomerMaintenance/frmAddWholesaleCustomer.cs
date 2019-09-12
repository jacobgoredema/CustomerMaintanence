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
    public partial class frmAddWholesaleCustomer : Form
    {
        public frmAddWholesaleCustomer()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            ShowDialog();
            return customer;
        }

        private Customer customer = null;

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new WholesaleCustomer(txtFirstname.Text, txtLastname.Text, txtEmail.Text,
                    txtCompany.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstname) &&
                    Validator.IsPresent(txtLastname) &&
                    Validator.IsPresent(txtEmail) &&
                    Validator.IsValidEmail(txtEmail) &&
                    Validator.IsPresent(txtCompany);
        }
    }
}
