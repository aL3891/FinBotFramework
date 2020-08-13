

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Trix
    /// </summary>
    [Keyless] 
    public class TRIX
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Trix { get; set; }
        public decimal Period { get; set; }
    }
}



