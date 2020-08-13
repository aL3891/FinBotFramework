using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Absolute price oscillator (APO)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=PriceOscillator.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class APO
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int FastPeriod { get; set; }
        public int SlowPeriod { get; set; }
        public int MaType { get; set; }
    }
}
