using System;
using System.Collections.Generic;
using System.Text;
using TinyCrm.core;

namespace TinyCrm.Core
{
    interface ICustomerService
    {
        bool CreateNewCustomer(AddCustomerOptions newCustomer);
        bool UpdateCustomerData(string CustomerId, UpdateCustomer UpCustomer);
        List<Customer> SearchCustomer(List<Customer> customerList);
    }
}
