

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Zero-Lag Exponential Moving Average
    /// </summary>
    [Keyless] 
    public class ZLEMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Zlema { get; set; }
        public decimal Period { get; set; }
    }
}



