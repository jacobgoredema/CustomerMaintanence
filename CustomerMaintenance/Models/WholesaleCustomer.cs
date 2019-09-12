using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance.Models
{
    public class WholesaleCustomer:Customer
    {
        private string company;

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public WholesaleCustomer()
        {

        }

        public WholesaleCustomer(string firstName, string lastName, string email, string company)
            :base(lastName,firstName,email)
        {
            this.company = company;
        }

        public override string GetDispayText()
        {
            return base.GetDispayText() + " (" + this.company + ")";
        }
    }
}
