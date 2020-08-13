using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Ultimate oscillator (ULTOSC)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=UltimateOsc.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class ULTOSC
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod1 { get; set; }
        public int TimePeriod2 { get; set; }
        public int TimePeriod3 { get; set; }
    }
}
