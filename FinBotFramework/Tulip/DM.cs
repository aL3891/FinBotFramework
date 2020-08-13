

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Directional Movement
    /// </summary>
    [Keyless] 
    public class DM
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Plus_dm { get; set; }
        public decimal Minus_dm { get; set; }
        public decimal Period { get; set; }
    }
}



