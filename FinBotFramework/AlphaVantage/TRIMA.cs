using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// The triangular moving average (TRIMA)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=TriangularMA.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class TRIMA
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
