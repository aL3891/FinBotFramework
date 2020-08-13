

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Momentum
    /// </summary>
    [Keyless] 
    public class MOM
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Mom { get; set; }
        public decimal Period { get; set; }
    }
}



