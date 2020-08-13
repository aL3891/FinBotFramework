

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Forecast Oscillator
    /// </summary>
    [Keyless] 
    public class FOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Fosc { get; set; }
        public decimal Period { get; set; }
    }
}



