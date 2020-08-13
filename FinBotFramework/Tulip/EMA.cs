

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Exponential Moving Average
    /// </summary>
    [Keyless] 
    public class EMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Ema { get; set; }
        public decimal Period { get; set; }
    }
}



