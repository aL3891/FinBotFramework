

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Absolute Price Oscillator
    /// </summary>
    [Keyless] 
    public class APO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Apo { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



