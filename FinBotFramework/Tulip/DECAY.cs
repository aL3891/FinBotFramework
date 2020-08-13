

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Linear Decay
    /// </summary>
    [Keyless] 
    public class DECAY
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Decay { get; set; }
        public decimal Period { get; set; }
    }
}



