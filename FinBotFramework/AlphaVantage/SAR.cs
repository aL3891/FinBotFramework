using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Parabolic SAR (SAR)
    /// <see href="http://www.investopedia.com/articles/technical/02/042202.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=SAR.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class SAR
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int acceleration { get; set; }
        public int maximum { get; set; }
    }
}
