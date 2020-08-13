

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Standard Deviation Over Period
    /// </summary>
    [Keyless] 
    public class STDDEV
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Stddev { get; set; }
        public decimal Period { get; set; }
    }
}



