

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Accumulation/Distribution Oscillator
    /// </summary>
    [Keyless] 
    public class ADOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Adosc { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



