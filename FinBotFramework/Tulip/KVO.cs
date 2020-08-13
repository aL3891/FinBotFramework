

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Klinger Volume Oscillator
    /// </summary>
    [Keyless] 
    public class KVO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Kvo { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



