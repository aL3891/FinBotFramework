

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Lag
    /// </summary>
    [Keyless] 
    public class LAG
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Lag { get; set; }
        public decimal Period { get; set; }
    }
}



