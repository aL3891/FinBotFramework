

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Relative Strength Index
    /// </summary>
    [Keyless] 
    public class RSI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Rsi { get; set; }
        public decimal Period { get; set; }
    }
}



