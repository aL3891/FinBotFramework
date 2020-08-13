

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Detrended Price Oscillator
    /// </summary>
    [Keyless] 
    public class DPO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Dpo { get; set; }
        public decimal Period { get; set; }
    }
}



