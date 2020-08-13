

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Weighted Moving Average
    /// </summary>
    [Keyless] 
    public class WMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Wma { get; set; }
        public decimal Period { get; set; }
    }
}



