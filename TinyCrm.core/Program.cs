using System;
using System.Collections.Generic;
using System.Linq;
using TinyCrm.core;
using TinyCrm.Core;

namespace TinyCRM
{
    class Program
    {
        public static List<Product> listOfProducts = new List<Product>();

        static void Main(string[] args)
        {
            var CustomerService = new CustomerService();
            CustomerService.CreateNewCustomer(new AddCustomerOptions
            {
                FirstName = "George",
                LastName = "Stathis",
                EmailAddress = "georgestathis1996@gmail.com",
                VatNumber = "039660333"
            });
            CustomerService.CreateNewCustomer(new AddCustomerOptions
            {
                FirstName = "Alexandros",
                LastName = "Papadopoulos",
                EmailAddress = "alexpapadopoulos@gmail.com",
                VatNumber = "152629060",

            });
            CustomerService.printList();
            var k = Console.ReadLine();
            CustomerService.UpdateCustomerData(k, new UpdateCustomer()
            {
                FirstName = "Giannis"
            });
            CustomerService.printList();
            //  Console.WriteLine(CustomerService.CustomerList.Count);
            //var q = Console.ReadLine();
            //CustomerService.UpdateCustomerData(q, new UpdateCustomer()
            //{
            //    FirstName = "kwstas"
            //});
            //CustomerService.printList();
            //var r = CustomerService.CustomerList[0].CustomerId;
            var product1 = new Product()
            {
                Id = "0001",
                Description = "A Lenovo laptop i3",
                Name = "LENOVO LAPTOP"
            };
            var product2 = new Product()
            {
                Id = "0002",
                Description = "A Lenovo laptop i5",
                Name = "LENOVO I5 LAPTOP"
            };
            var product3 = new Product()
            {
                Id = "0003",
                Description = "A Lenovo laptop i7",
                Name = "LENOVO I7 LAPTOP"
            };
            //var ProductService = new ProductService();
            //var OrderService = new OrderService();

            //listOfProducts.Add(product1);
            //listOfProducts.Add(product2);
            //listOfProducts.Add(product2);

            ////var orderproductList = new List<Product>();
            ////orderproductList = listOfProducts;
            //OrderService.AddOrder(k, new AddOrderOption
            //{
            //    DeliveryAddress = "saDAS",
            //    OrderProductList = listOfProducts

            //});


            //Console.WriteLine("ASDASDASDASD");
            //var po = Console.ReadLine();
            //OrderService.AddOrder(po, listOfProducts);
            //Console.WriteLine("DSfSD"+CustomerService.GetCustomerById(po).Orders.Count);
            ////foreach(Customer i in CustomerService.CustomerList) {
            ////    foreach (Order t in i.Orders) {
            //        Console.WriteLine(i.FirstName + i.LastName + t.CustomerName + t.DeliveryAddress);
            //    }
            //}

            ////CustomerService.CustomerList;
        }
    }
}
