using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCrm.Core;

namespace TinyCrm.core
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> CustomerList = new List<Customer>();
        //O neos pelatis prepei na exei sumplirwmena toulaxiston onoma epwnumo, email kai afm
        public bool CreateNewCustomer(AddCustomerOptions customer)
        {
            if (customer == null) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(customer.FirstName)) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(customer.LastName)) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(customer.EmailAddress)) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(customer.VatNumber) || CustomerList.Where(s => s.VatNumber == customer.VatNumber) == null) {

                return false;
            }

            var newCustomer = new Customer()
            {
                EmailAddress = customer.EmailAddress,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                VatNumber = customer.VatNumber,
                CustomerId = AddCustomerOptions.RandomGeneratorCustomerId(),
                dateCreated = DateTimeOffset.Now.Date,
            };

            if (CustomerList.Contains(newCustomer)) {
                return false;
            }
            CustomerList.Add(newCustomer);
            return true;
        }
        public bool UpdateCustomerData(string CustomerId, UpdateCustomer UpCustomer)
        {
            if (UpCustomer == null) { return false; }
            if (CustomerList.Find(c=>c.CustomerId==CustomerId)==null) {
                return false;
            }
            var customer = CustomerList.Find(p => p.CustomerId == CustomerId);
            CustomerList.Remove(customer);
            // Console.WriteLine(customer.CustomerId + customer.EmailAddress);
            if (!string.IsNullOrWhiteSpace(UpCustomer.FirstName)) {
                customer.FirstName = UpCustomer.FirstName;
                //    CustomerList[CustomerList.FindIndex(ind => ind.CustomerId.Equals(CustomerId))].FirstName = UpCustomer.FirstName;
            }
            if (!string.IsNullOrWhiteSpace(UpCustomer.LastName)) {
                customer.LastName = UpCustomer.LastName;
                //  CustomerList[CustomerList.FindIndex(ind => ind.CustomerId.Equals(CustomerId))].LastName = UpCustomer.LastName;
            }
            if ((UpCustomer.status == false)) {
                //   CustomerList[CustomerList.FindIndex(ind => ind.CustomerId.Equals(CustomerId))].status = UpCustomer.status;
                customer.status = UpCustomer.status;

            }
            if (!string.IsNullOrWhiteSpace(UpCustomer.EmailAddress)) {
                //   CustomerList[CustomerList.FindIndex(ind => ind.CustomerId.Equals(CustomerId))].EmailAddress = UpCustomer.EmailAddress;
                customer.EmailAddress = UpCustomer.EmailAddress;
            }
            if (UpCustomer.VatNumber != null) {
                //  CustomerList[CustomerList.FindIndex(ind => ind.CustomerId.Equals(CustomerId))].VatNumber = UpCustomer.VatNumber;
                customer.VatNumber = UpCustomer.VatNumber;
            }
            // Console.WriteLine(customer.FirstName + customer.LastName + customer.EmailAddress + customer.CustomerId);

            // CustomerList.Remove(CustomerList.Where(i => i.CustomerId == CustomerId).FirstOrDefault());
            CustomerList.Add(customer);

            return true;
        }
        public List<Customer> SearchCustomer(List<Customer> customerList)
        {
            var ActiveCustomerList = customerList.Where(c => c.status.Equals("active")).ToList();
            return ActiveCustomerList;
        }
        public static Customer GetCustomerById(string customId)
        {
            Customer customer = CustomerList.Where(s => s.CustomerId == customId).FirstOrDefault();
            return customer;
        }


        public void printList()
        {
            foreach (Customer u in CustomerList) {
                Console.WriteLine(u.EmailAddress + u.FirstName + u.LastName
                    + u.CustomerId + u.dateCreated);
            }
            //CustomerList.Find(c => c.LastName == "Stathis").LastName = "dimitrakomanolopoulos";
            //foreach (Customer u in CustomerList) {
            //    Console.WriteLine(u.EmailAddress + u.FirstName + u.LastName
            //        + u.CustomerId + u.dateCreated);
            //}
        }

        //public static bool isExistCustomer(string CustomerId)
        //{
        //    if (CustomerList.Where(s => s.CustomerId == CustomerId) != null) {
        //        return true;
        //    }
        //    return false;
        //}
        public static string RandomGeneratorCustomerId()
        {
            Random r = new Random();
            var randomNum = r.Next(1, 1000);
            var rrandomId = randomNum.ToString("#A" + r.Next(1, 50) + "Z#");

            if (CustomerService.CustomerList.Where(s => s.CustomerId == rrandomId) == null) {
                RandomGeneratorCustomerId();
            }
            return rrandomId;
            //auth thn function na thn valw sthn klash customer kai anti gia lista 
            //customerList na exw customerIdList

        }
    }
}
