

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Chaikins Volatility
    /// </summary>
    [Keyless] 
    public class CVI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Cvi { get; set; }
        public decimal Period { get; set; }
    }
}



