using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Money flow index (MFI)
    /// <see href="http://www.investopedia.com/articles/technical/03/072303.asp">Investopedia article</see>,
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=MoneyFlowIndex.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class MFI
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
