using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance.Models
{
    public class RetailCustomer:Customer
    {
        private string homePhone;

        public string HomePhone
        {
            get
            {
                return homePhone;
            }

            set
            {
                homePhone = value;
            }
        }

        public RetailCustomer()
        {

        }

        public RetailCustomer(string firstname,string lastname,string email,string homePhone)
            :base(firstname,lastname,email)
        {
            this.homePhone = homePhone;
        }

        public override string GetDispayText()
        {
            return base.GetDispayText() + " ph: " + this.homePhone;
        }
    }
}
