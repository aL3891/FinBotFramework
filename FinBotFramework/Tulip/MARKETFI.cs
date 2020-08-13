

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Market Facilitation Index
    /// </summary>
    [Keyless] 
    public class MARKETFI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Marketfi { get; set; }
    }
}



