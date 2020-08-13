using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinBotNet
{
    public class Account
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        public decimal Value { get; set; }
        public decimal Balance { get; set; }
        List<Order> Orders { get; set; }

        public async Task Place(Order order)
        {
            Orders.Add(order);
        }
    }
}
