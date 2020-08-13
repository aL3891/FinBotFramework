

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Aroon
    /// </summary>
    [Keyless] 
    public class AROON
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Aroon_down { get; set; }
        public decimal Aroon_up { get; set; }
        public decimal Period { get; set; }
    }
}



