

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Money Flow Index
    /// </summary>
    [Keyless] 
    public class MFI
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Mfi { get; set; }
        public decimal Period { get; set; }
    }
}



