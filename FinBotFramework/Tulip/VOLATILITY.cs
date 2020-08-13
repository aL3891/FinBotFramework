

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Annualized Historical Volatility
    /// </summary>
    [Keyless] 
    public class VOLATILITY
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Volatility { get; set; }
        public decimal Period { get; set; }
    }
}



