

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Wilders Smoothing
    /// </summary>
    [Keyless] 
    public class WILDERS
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Wilders { get; set; }
        public decimal Period { get; set; }
    }
}



