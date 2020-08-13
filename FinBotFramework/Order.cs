using System;

namespace FinBotNet
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public DateTime Date { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }

        public Account Account { get; set; }
    }
}
