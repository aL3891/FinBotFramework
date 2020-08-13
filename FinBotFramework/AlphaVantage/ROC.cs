using Microsoft.EntityFrameworkCore;
using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Rate of change (ROC) 
    /// <see href="http://www.investopedia.com/articles/technical/092401.asp">Investopedia article</see>,
    /// </summary>
    [Keyless]
    public class ROC
    {
        public Stock Stock { get; set; }
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
