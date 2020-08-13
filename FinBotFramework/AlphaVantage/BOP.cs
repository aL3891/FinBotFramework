using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Balance of power (BOP)
    /// </summary>
    [Keyless] public class BOP
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
