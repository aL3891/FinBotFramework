

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Chande Momentum Oscillator
    /// </summary>
    [Keyless] 
    public class CMO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Cmo { get; set; }
        public decimal Period { get; set; }
    }
}



