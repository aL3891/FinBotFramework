using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Average true range (ATR)
    /// <see href="http://www.investopedia.com/articles/trading/08/average-true-range.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=ATR.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class ATR
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
