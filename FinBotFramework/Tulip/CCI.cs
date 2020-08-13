

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Commodity Channel Index
    /// </summary>
    [Keyless] 
    public class CCI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Cci { get; set; }
        public decimal Period { get; set; }
    }
}



