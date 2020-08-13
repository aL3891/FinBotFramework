﻿using Microsoft.EntityFrameworkCore; using System;

namespace FinBotNet.AlphaVantage
{
    /// <summary>
    /// Triple exponential moving average (TEMA)
    /// <see href="http://www.fmlabs.com/reference/default.htm?url=TEMA.htm">Indicator reference</see>
    /// </summary>
    [Keyless] public class TEMA
    {
        public Stock Stock { get; set; } public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public TimeSpan Interval { get; set; }
        public int TimePeriod { get; set; }
    }
}
