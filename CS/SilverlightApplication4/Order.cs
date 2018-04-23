using System;
using System.Collections.Generic;

namespace SilverlightApplication4
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { OrderId = 0, Description = "Sterio", Price = 2000 });
            orders.Add(new Order() { OrderId = 1, Description = "XP Radio", Price = 1000 });
            orders.Add(new Order() { OrderId = 2, Description = "Cell Phone", Price = 200 });
            orders.Add(new Order() { OrderId = 3, Description = "Sterio", Price = 2000 });
            orders.Add(new Order() { OrderId = 4, Description = "Cell Phone", Price = 200 });
            orders.Add(new Order() { OrderId = 5, Description = "Head Set", Price = 100 });
            orders.Add(new Order() { OrderId = 6, Description = "Keyboard", Price = 100 });
            orders.Add(new Order() { OrderId = 7, Description = "Cell Phone", Price = 200 });
            return orders;
        }
    }
}
