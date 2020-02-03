using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrm.core
{
    public class Order
    {
        private string Orderid;
        /// <summary>
        /// 
        /// </summary>
        public string OrderId
        {
            get { return Orderid; }
            set {
                Orderid = RandomGeneratorOrderId();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryAddress { get; set; }
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal TotalMount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Product> OrderProductList;
        public string OrderStatus { get; set; }
        public string RandomGeneratorOrderId()
        {
            Random r = new Random();
            var randomNum = r.Next(1, 1000);
            var rrandomId = randomNum.ToString("#A#" + r.Next(1, 50) + "#Z#");
            //if (!OrderId.Contains(rrandomId)) {
            //    OrderId.Add(rrandomId);
            //} else { RandomGeneratorOrderId(); }
            return rrandomId;
        }

    }
}

