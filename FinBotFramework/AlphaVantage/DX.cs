using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Directional movement index (DX)
    /// <see href="http://www.investopedia.com/articles/technical/02/050602.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=DX.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class DX
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
