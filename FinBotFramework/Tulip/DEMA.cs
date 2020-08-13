

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Double Exponential Moving Average
    /// </summary>
    [Keyless] 
    public class DEMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Dema { get; set; }
        public decimal Period { get; set; }
    }
}



