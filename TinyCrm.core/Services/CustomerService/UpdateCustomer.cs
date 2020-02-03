using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TinyCrm.Core
{
    public class UpdateCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string VatNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool status { get; set; }
        //public Customer GetCustomerById(string customId)
        //{
        //    var customer = CustomerService.CustomerList.Where(s => s.CustomerId == customId).FirstOrDefault();
        //    return customer;
        //}

    }
}
