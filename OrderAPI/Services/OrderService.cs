using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Services
{
    public class OrderService
    {
        private readonly OrderContext _orderContext;

        public OrderService(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public ICollection<Order> Get()
        {
            IList<Order> order = _orderContext.orders.ToList();
            return order;
        }
        public Order Add(Order order)
        {
            _orderContext.orders.Add(order);
            _orderContext.SaveChanges();
            return order;
        }
        public Order Getid(int id)
        {
            Order order = _orderContext.orders.FirstOrDefault(e => e.OrderID == id);
            return order;
        }

        public Order Create (UserDTO userDTO)
        {
            Order ord;
            ord = new Order() { UserID = userDTO.UserId, OrderTotal = 0, DeliveryCharge = 0 };
            _orderContext.orders.Update(ord);
            _orderContext.SaveChanges();
            return ord;
        }
    }
}
