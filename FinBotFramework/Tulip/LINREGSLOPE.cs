

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Linear Regression Slope
    /// </summary>
    [Keyless] 
    public class LINREGSLOPE
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Linregslope { get; set; }
        public decimal Period { get; set; }
    }
}



