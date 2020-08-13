using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Average directional movement index rating (ADXR)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=ADXR.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class ADXR
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
