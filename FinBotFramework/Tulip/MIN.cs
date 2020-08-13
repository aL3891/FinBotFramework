

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Minimum In Period
    /// </summary>
    [Keyless] 
    public class MIN
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Min { get; set; }
        public decimal Period { get; set; }
    }
}



