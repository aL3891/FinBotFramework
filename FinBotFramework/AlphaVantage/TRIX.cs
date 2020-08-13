using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// 1-day rate of change of a triple smooth exponential moving average (TRIX) 
    /// <see href="http://www.investopedia.com/articles/technical/02/092402.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=TRIX.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class TRIX
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
