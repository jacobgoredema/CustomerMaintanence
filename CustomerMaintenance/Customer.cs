using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Customer
    {
        private string firstname;
        private string lastname;
        private string email;

        public Customer()
        {

        }

        public Customer(string firstname,string lastname, string email)
        {
            FirstName = firstname;
            Lastname = lastname;
            Email = email;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string GetDispayText() => firstname + " " + lastname + ", " + email;
    }
}
