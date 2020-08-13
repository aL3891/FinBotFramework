

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Average True Range
    /// </summary>
    [Keyless] 
    public class ATR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Atr { get; set; }
        public decimal Period { get; set; }
    }
}



