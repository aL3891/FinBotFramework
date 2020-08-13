

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Variable Index Dynamic Average
    /// </summary>
    [Keyless] 
    public class VIDYA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Vidya { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
        public decimal Alpha { get; set; }
    }
}



