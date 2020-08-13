

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Normalized Average True Range
    /// </summary>
    [Keyless] 
    public class NATR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Natr { get; set; }
        public decimal Period { get; set; }
    }
}



