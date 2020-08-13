using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Aroon oscillator (AROONOSC)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=AroonOscillator.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class AROONOSC
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
