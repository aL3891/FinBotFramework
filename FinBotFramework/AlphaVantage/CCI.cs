using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Commodity channel index (CCI)
    /// <see href="http://www.investopedia.com/articles/trading/05/041805.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=CCI.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class CCI
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
