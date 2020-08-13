

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Stochastic RSI
    /// </summary>
    [Keyless] 
    public class STOCHRSI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Stochrsi { get; set; }
        public decimal Period { get; set; }
    }
}



