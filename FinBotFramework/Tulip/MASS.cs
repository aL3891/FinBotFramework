

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Mass Index
    /// </summary>
    [Keyless] 
    public class MASS
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Mass { get; set; }
        public decimal Period { get; set; }
    }
}



