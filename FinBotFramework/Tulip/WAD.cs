

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Williams Accumulation/Distribution
    /// </summary>
    [Keyless] 
    public class WAD
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Wad { get; set; }
    }
}



