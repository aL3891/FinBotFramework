

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Maximum In Period
    /// </summary>
    [Keyless] 
    public class MAX
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Max { get; set; }
        public decimal Period { get; set; }
    }
}



