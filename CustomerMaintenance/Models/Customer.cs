using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string firstname;
        private string lastname;
        private string email;

        public Customer()
        {

        }

        /// <summary>
        /// Creates a Customer object with the specified values.
        /// </summary>
        /// <param name="firstname">The firstname to be stored in the object.</param>
        /// <param name="lastname">The last name  to be stored in the object.</param>
        /// <param name="email">The email  to be stored in the object.</param>
        public Customer(string firstname,string lastname, string email)
        {
            FirstName = firstname;
            Lastname = lastname;
            Email = email;
        }

        /// <summary>
        /// Gets or sets the customer's first name
        /// </summary>
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

        /// <summary>
        /// Gets or sets the customer's last name
        /// </summary>
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

        /// <summary>
        /// Gets or sets the customer's email
        /// </summary>
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

        /// <summary>
        /// Concatenates the first name, last name, and email address for display.
        /// </summary>
        /// <returns>The formatted string</returns>
        public virtual string GetDispayText() => firstname + " " + lastname + ", " + email;
    }
}
