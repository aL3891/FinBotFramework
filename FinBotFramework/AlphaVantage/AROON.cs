using Microsoft.EntityFrameworkCore;
using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Aroon (AROON)
    /// <see href="http://www.investopedia.com/articles/trading/06/aroon.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=Aroon.htm">Indicator reference</see>
    /// </summary>
    [Keyless]
    public class AROON
    {
        public Stock Stock { get; set; }
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
