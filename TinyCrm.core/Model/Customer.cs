using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TinyCrm.core
{
    public class Customer
    {

        public string FirstName { get; set; }
        private string Customerid;
        public string CustomerId { get; set; }
        public DateTime dateCreated { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }
        public string VatNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool status { get { return status; } set { status = true; } }//ACTIVE -> TRUE
        public decimal TotalMoney { get; set; }
        //public string RandomGeneratorCustomerId()
        //{
        //    Random r = new Random();
        //    var randomNum = r.Next(1, 1000);
        //    var rrandomId = randomNum.ToString("#A" + r.Next(1, 50) + "Z#");

        //    if (CustomerService.CustomerList.Where(s => s.CustomerId == rrandomId) == null) {
        //        RandomGeneratorCustomerId();
        //    }
        //    return rrandomId;

        //}
    }
}
