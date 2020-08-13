

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Ultimate Oscillator
    /// </summary>
    [Keyless] 
    public class ULTOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Ultosc { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal MediumPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



