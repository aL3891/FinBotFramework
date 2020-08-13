

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Moving Average Convergence/Divergence
    /// </summary>
    [Keyless] 
    public class MACD
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Macd { get; set; }
        public decimal Macd_signal { get; set; }
        public decimal Macd_histogram { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
        public decimal SignalPeriod { get; set; }
    }
}



