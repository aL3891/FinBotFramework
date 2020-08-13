using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// On balance volume (OBV) 
    /// <see href="http://www.investopedia.com/articles/technical/100801.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=OBV.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class OBV
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
