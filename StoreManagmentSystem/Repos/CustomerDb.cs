using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class CustomerDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Customer AddCustomer(Customer cst)
        {
            db.Customers.Add(cst);
            db.SaveChanges();

            return cst;
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer EditCustomer(Customer cst)
        {
            Customer customer = GetCustomerById(cst.ID);

            customer.Mobile = cst.Mobile;
            customer.Name = cst.Name;
            customer.Telephone = cst.Telephone;
            customer.Email = cst.Email;
            customer.Website = cst.Website;
            customer.Fax = cst.Fax;

            db.SaveChanges();

            return cst;
        }

        public void DeleteCustomerByCustomer(Customer cst)
        {
            db.Customers.Remove(cst);
            db.SaveChanges();
        }

        public void DeleteCustomerById(int id)
        {
            DeleteCustomerByCustomer(GetCustomerById(id));
        }
    }
}
