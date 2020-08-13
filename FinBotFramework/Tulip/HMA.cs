

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Hull Moving Average
    /// </summary>
    [Keyless] 
    public class HMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hma { get; set; }
        public decimal Period { get; set; }
    }
}



