using Microsoft.EntityFrameworkCore;
using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Average directional movement index (ADX)
    /// <see href="http://www.investopedia.com/articles/trading/07/adx-trend-indicator.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=ADX.htm">Indicator reference</see>
    /// </summary>
    [Keyless]
    public class ADX
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
