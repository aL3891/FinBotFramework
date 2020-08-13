using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Stochastic relative strength index (STOCHRSI)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=StochRSI.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class STOCHRSI
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
        public int fastkperiod { get; set; }
        public int fastdperiod { get; set; }
        public int fastdmatype { get; set; }
    }
}
