using System;

namespace FinBotNet
{
    public class StockPrice
    {
        public string StockId { get; set; }
        public Stock Stock { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public int Volume { get; set; }
        public TimeSpan TimeSpan { get; set; }
    }
}
