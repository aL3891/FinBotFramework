

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Williams %R
    /// </summary>
    [Keyless] 
    public class WILLR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Willr { get; set; }
        public decimal Period { get; set; }
    }
}



