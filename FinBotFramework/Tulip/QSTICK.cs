

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Qstick
    /// </summary>
    [Keyless] 
    public class QSTICK
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Qstick { get; set; }
        public decimal Period { get; set; }
    }
}



