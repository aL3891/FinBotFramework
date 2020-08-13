using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Stochastic fast (STOCHF)
    /// <see href="http://www.investopedia.com/university/indicator_oscillator/ind_osc8.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=StochasticOscillator.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class STOCKF
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int fastkperiod { get; set; }
        public int fastdperiod { get; set; }
        public int fastdmatype { get; set; }

    }
}
