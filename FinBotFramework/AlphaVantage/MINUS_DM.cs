using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// The minus directional movement (MINUS_DM)
    /// <see href="http://www.investopedia.com/articles/technical/02/050602.asp">Investopedia article</see>
    /// </summary>
    [Keyless] public class MINUS_DM
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
