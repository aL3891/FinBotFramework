using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Double exponential moving average (DEMA)
    /// <see href="http://www.investopedia.com/articles/trading/10/double-exponential-moving-average.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=DEMA.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class DEMA
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
