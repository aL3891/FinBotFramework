

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Variance Over Period
    /// </summary>
    [Keyless] 
    public class VAR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Var { get; set; }
        public decimal Period { get; set; }
    }
}



