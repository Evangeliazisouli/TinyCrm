using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TinyCrm.core
{
    public class AddCustomerOptions
    {
      //  private string customerId;
        public string FirstName { get; set; }
        public string CustomerId{get; set;}
        public string LastName { get; set; }
        //  public List<Order> Orders { get; set; }
        public string VatNumber { get; set; }
        public string EmailAddress { get; set; }
        public string status { get; set; }
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
