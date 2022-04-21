using System;
using System.Collections.Generic;
using CouseAula132ExercicioProposto.Entities.Enums;
namespace CouseAula132ExercicioProposto.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client  { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void removeItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
            
        }
    }
}
