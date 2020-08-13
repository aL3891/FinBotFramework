

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Simple Moving Average
    /// </summary>
    [Keyless] 
    public class SMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Sma { get; set; }
        public decimal Period { get; set; }
    }
}



