using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Hilbert transform, instantaneous trendline (HT_TRENDLINE)
    /// <see href="">Investopedia article</see>,
    /// <see href="">Indicator reference</see>
    /// </summary>
    [Keyless] public class HT_TRENDLINE
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
