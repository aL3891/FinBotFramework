

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Linear Regression
    /// </summary>
    [Keyless] 
    public class LINREG
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Linreg { get; set; }
        public decimal Period { get; set; }
    }
}



