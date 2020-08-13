

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Exponential Decay
    /// </summary>
    [Keyless] 
    public class EDECAY
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Edecay { get; set; }
        public decimal Period { get; set; }
    }
}



