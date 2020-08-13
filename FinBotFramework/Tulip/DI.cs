

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Directional Indicator
    /// </summary>
    [Keyless] 
    public class DI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Plus_di { get; set; }
        public decimal Minus_di { get; set; }
        public decimal Period { get; set; }
    }
}



