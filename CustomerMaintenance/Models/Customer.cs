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
                if (value.Length>30)
                {
                    throw new ArgumentException("Maximun length of first name is 50 characters.");
                }

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
                if(value.Length>30)
                {
                    throw new ArgumentException("Maximum length of last name is 50 characters.");
                }

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
                //if (value.Length>30)
                //{
                //    throw new ArgumentException("Maximum length for email is 50 characters.");
                //}

                email = value;
            }
        }

        public virtual string GetDispayText() => firstname + " " + lastname + ", " + email;
    }
}
