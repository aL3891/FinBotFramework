

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Fisher Transform
    /// </summary>
    [Keyless] 
    public class FISHER
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Fisher { get; set; }
        public decimal Fisher_signal { get; set; }
        public decimal Period { get; set; }
    }
}



