using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class CustomerDb
    {
        private const string dir= @"C:\2015\Files";
        private const string path = dir + " Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
        {
            // crteate the output stream for a text file that exists
            StreamWriter textOut = new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Customer customer in customers)
            {
                textOut.Write(customer.FirstName + "|");
                textOut.Write(customer.Lastname + "|");
                textOut.WriteLine(customer.Email);
            }

            // write the end of the document
            textOut.Close();
        }

        public static List<Customer> GetCustomers()
        {
            // if the directory doesnt exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //create the object for the input stream for a text file
            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Customer> customers = new List<Customer>();

            //read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');

                Customer customer = new Customer();
                customer.FirstName = columns[0];
                customer.Lastname = columns[1];
                customer.Email = columns[2];

                customers.Add(customer);

            }

            textIn.Close();

            return customers;
        }
    }
}
