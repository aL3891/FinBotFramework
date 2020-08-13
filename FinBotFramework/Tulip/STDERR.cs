

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Standard Error Over Period
    /// </summary>
    [Keyless] 
    public class STDERR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Stderr { get; set; }
        public decimal Period { get; set; }
    }
}



