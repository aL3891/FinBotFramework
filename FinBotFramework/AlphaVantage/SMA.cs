using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Simple moving average (SMA)
    /// <see href="http://www.investopedia.com/articles/technical/052201.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=SimpleMA.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class SMA
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
