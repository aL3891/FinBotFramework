using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Stochastic oscillator (STOCH)
    /// <see href="http://www.investopedia.com/university/indicator_oscillator/ind_osc8.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=StochasticOscillator.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class STOCH
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }

        public int fastkperiod { get; set; }
        public int slowkperiod { get; set; }
        public int slowdperiod { get; set; }
        public int slowkmatype { get; set; }
        public int slowdmatype { get; set; }

    }
}
