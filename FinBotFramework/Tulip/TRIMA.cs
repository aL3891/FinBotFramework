

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Triangular Moving Average
    /// </summary>
    [Keyless] 
    public class TRIMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Trima { get; set; }
        public decimal Period { get; set; }
    }
}



