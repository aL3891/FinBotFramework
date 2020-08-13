

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Kaufman Adaptive Moving Average
    /// </summary>
    [Keyless] 
    public class KAMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Kama { get; set; }
        public decimal Period { get; set; }
    }
}



