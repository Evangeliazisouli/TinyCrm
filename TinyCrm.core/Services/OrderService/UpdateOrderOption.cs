using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrm.Core.Services.OrderService
{
    public class UpdateOrderOption
    {
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool TobeCancel { get { return TobeCancel; }set { TobeCancel = false; ; } }
        /// <summary>
        /// 
        /// </summary>

        public string OrderStatus { get; set; }
    }
}
