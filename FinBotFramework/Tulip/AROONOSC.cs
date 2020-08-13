

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Aroon Oscillator
    /// </summary>
    [Keyless] 
    public class AROONOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Aroonosc { get; set; }
        public decimal Period { get; set; }
    }
}



