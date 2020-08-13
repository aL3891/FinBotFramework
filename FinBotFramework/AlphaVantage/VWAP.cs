using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Volume weighted average price (VWAP)
    /// <see href="https://www.investopedia.com/terms/v/vwap.asp">Investopedia article</see>,
    /// </summary>
    [Keyless] public class VWAP
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
