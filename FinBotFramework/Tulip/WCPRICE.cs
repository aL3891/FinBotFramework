

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Weighted Close Price
    /// </summary>
    [Keyless] 
    public class WCPRICE
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Wcprice { get; set; }
    }
}



