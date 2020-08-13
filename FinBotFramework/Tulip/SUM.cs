

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Sum Over Period
    /// </summary>
    [Keyless] 
    public class SUM
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Sum { get; set; }
        public decimal Period { get; set; }
    }
}



