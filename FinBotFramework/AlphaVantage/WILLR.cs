using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Williams' %R (WILLR)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=WilliamsR.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class WILLR
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
