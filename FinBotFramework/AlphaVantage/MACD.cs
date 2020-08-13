using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Moving average convergence / divergence (MACD)
    /// <see href="http://www.investopedia.com/articles/forex/05/macddiverge.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=MACD.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class MACD
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int FastPeriod { get; set; }
        public int SlowPeriod { get; set; }
        public int SignalPeriod { get; set; }
    }
}
