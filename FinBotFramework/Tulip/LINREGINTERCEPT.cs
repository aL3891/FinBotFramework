

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Linear Regression Intercept
    /// </summary>
    [Keyless] 
    public class LINREGINTERCEPT
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Linregintercept { get; set; }
        public decimal Period { get; set; }
    }
}



