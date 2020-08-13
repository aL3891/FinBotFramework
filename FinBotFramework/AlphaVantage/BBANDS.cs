using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Bollinger bands (BBANDS) 
    /// <see href="http://www.investopedia.com/articles/technical/04/030304.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=Bollinger.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class BBANDS
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
        public int nbdevup { get; set; }
        public int nbdevdn { get; set; }
        public int matype { get; set; }
    }
}
