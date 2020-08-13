

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Vertical Horizontal Filter
    /// </summary>
    [Keyless] 
    public class VHF
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Vhf { get; set; }
        public decimal Period { get; set; }
    }
}



