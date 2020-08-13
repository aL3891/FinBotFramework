using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Plus directional indicator (PLUS_DI) 
    /// <see href="http://www.investopedia.com/articles/technical/02/050602.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=DI.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class PLUS_DI
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
