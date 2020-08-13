

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Volume Weighted Moving Average
    /// </summary>
    [Keyless] 
    public class VWMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Vwma { get; set; }
        public decimal Period { get; set; }
    }
}



