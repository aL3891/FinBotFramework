

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Volume Oscillator
    /// </summary>
    [Keyless] 
    public class VOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Vosc { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



