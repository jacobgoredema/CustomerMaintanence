using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance.Models
{
    public class CustomerList
    {
        private List<Customer> customers;
        public delegate void ChangeHandler(CustomerList customers);
        public event ChangeHandler Changed;

        public int Count => customers.Count;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public Customer this[int i]
        {
            get
            {
                return customers[i];
            }
            set
            {
                customers[i] = value;
                Changed(this);
            }
        }

        public void Fill() => customers = CustomerDb.GetCustomers();
        public void Save() => CustomerDb.SaveCustomers(customers);

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Changed(this);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            Changed(this);
        }

        public static CustomerList operator + (CustomerList c1, Customer c)
        {
            c1.Add(c);
            return c1;
        }

        public static CustomerList operator - (CustomerList c1, Customer c)
        {
            c1.Remove(c);
            return c1;
        }
    }
}
