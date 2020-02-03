using System;
using System.Collections.Generic;
using System.Text;
using TinyCrm.core;
using TinyCrm.Core.Services.OrderService;

namespace TinyCrm.Core
{
    interface IOrderService
    {
        Order GetOrderById(string orderId);
        bool AddOrder(string customerId, AddOrderOption addOrder);
        bool UpdateOrder(string orderId, UpdateOrderOption order);
    }
}
