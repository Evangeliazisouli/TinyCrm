using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TinyCrm.Core.Services.OrderService;
using TinyCrm.core;
using TinyCRM;

namespace TinyCrm.Core
{
    public class OrderService : IOrderService
    {
        private List<Order> OrdersList = new List<Order>();
        public static List<Order> ProcessingOrders = new List<Order>();
        public bool AddOrder(string customerId, AddOrderOption addOrder)
        {
            if (addOrder == null) {
                return false;
            }
            if (CustomerService.CustomerList.Where(p => p.CustomerId == customerId) == null) {
                return false;
            }
            if (addOrder.OrderProductList == null) {
                Console.WriteLine("The list of products must not be null");
                return false;
            }
            var customer1 = CustomerService.GetCustomerById(customerId);
            //if (customer1.status==true) {
            //    return false;
            //}
            //if (options != null) {
            //    return false;
            //}
            //Console.WriteLine(cus.CustomerId + cus.LastName+cus.Orders.Count());
            var neworder = new Order()
            {
                CustomerName = CustomerService.CustomerList.Find(p => p.CustomerId == customerId).LastName,
                OrderStatus = "Sad",
                DeliveryAddress = "PPP",
                OrderId = "#24#",
                OrderProductList = isExistedProduct(addOrder.OrderProductList),
                TotalMount = CalculateOrderCost(isExistedProduct(addOrder.OrderProductList)),
            };


            CustomerService.CustomerList.Find(p => p.CustomerId == customerId).Orders.Add(neworder);
            ProcessingOrders.Add(neworder);
            Console.WriteLine("mpike");
            //if (neworder != null) {
            //    Console.WriteLine(neworder.DeliveryAddress);
            //    Console.WriteLine(customer.Orders.Count);
            //}  //neworder.OrderProductList = listOfProducts;
            //   cus.Orders.Add(neworder);
            //cus.Orders.Add(neworder);
            //   Console.WriteLine(cus.CustomerId + cus.dateCreated + cus.EmailAddress + cus.Orders.FirstOrDefault().OrderProductList.FirstOrDefault().Description);
            return true;
        }
        public bool UpdateOrder(string orderId, UpdateOrderOption orderForUpdate)
        {
            if (OrdersList.Find(o => o.OrderId.Equals(orderId)) == null) {
                return false;
            }
            if (orderForUpdate.TobeCancel == true) {
                //edw prepei na to bgaze kai apo ton customer
                OrdersList.Remove(OrdersList.Find(o => o.OrderId.Equals(orderId)));
                //CustomerService.CustomerList.Remove(CustomerService.CustomerList.Find(id=>id.CustomerId.Equals(cu)))
                return true;
            }
            //if (!orderForUpdate.OrderStatus.Equals("not-executable")) {
            //    return false;
            //}
            return true;

        }
        public Order GetOrderById(string orderid)
        {
            if (!string.IsNullOrWhiteSpace(orderid)) {
                return null;
            }
            var detailsOrder = OrdersList.Where(s => s.OrderId.Equals(orderid)).FirstOrDefault();
            return detailsOrder;

        }
        public List<Product> isExistedProduct(List<Product> orderproductlist)
        {
            List<Product> validlist = new List<Product>();
            foreach (Product i in orderproductlist) {
                if (Program.listOfProducts.Contains(i)) {
                    validlist.Add(i);
                }

            }
            return validlist;
        }
        public decimal CalculateOrderCost(List<Product> productlist)
        {
            var totalcost = 0.00M;
            foreach (Product i in productlist) {
                totalcost += i.Price;
            }
            return totalcost;
        }

        Order IOrderService.GetOrderById(string orderId)
        {
            throw new NotImplementedException();
        }
    }
}
