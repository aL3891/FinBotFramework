using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Chaikin A/D oscillator (ADOSC)
    /// <see href="http://www.investopedia.com/articles/active-trading/031914/understanding-chaikin-oscillator.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=AccumDist.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class ADOSC
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int FastPeriod { get; set; }
        public int SlowPeriod { get; set; }
    }
}
