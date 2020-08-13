

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Mean Deviation Over Period
    /// </summary>
    [Keyless] 
    public class MD
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Md { get; set; }
        public decimal Period { get; set; }
    }
}



