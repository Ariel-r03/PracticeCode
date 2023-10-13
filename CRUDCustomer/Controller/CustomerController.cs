using CRUDCustomer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCustomer.Controller
{
    internal class CustomerController
    {
        Customer customer = new Customer();
        public List<Customer> Customers()
        {
            return customer.getCustomer();
        }

        public void Add(Customer customer)
        {
                customer.AddCustomer(customer);
            
        }

        public void Delete(string customerID)
        {
            if(customerID == null)
            {
                MessageBox.Show("El cliente no existe");

            }
            else
            {
                customer.DeleteCustomer(customerID);
            }
        }

        public Customer GetCustomer(string customerID)
        {
            return customer.getOneCustomer(customerID);
        }

        public void Update(Customer customer)
        {
            customer.UpdateCustomer(customer);
        }
    }
}
