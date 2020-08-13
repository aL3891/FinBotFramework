

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Bollinger Bands
    /// </summary>
    [Keyless] 
    public class BBANDS
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Bbands_lower { get; set; }
        public decimal Bbands_middle { get; set; }
        public decimal Bbands_upper { get; set; }
        public decimal Period { get; set; }
        public decimal Stddev { get; set; }
    }
}



