using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Weighted moving average (WMA) values
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=WeightedMA.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class WMA
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
