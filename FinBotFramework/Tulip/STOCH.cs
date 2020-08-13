

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Stochastic Oscillator
    /// </summary>
    [Keyless] 
    public class STOCH
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Stoch_k { get; set; }
        public decimal Stoch_d { get; set; }
        public decimal KPeriod { get; set; }
        public decimal KSlowingPeriod { get; set; }
        public decimal DPeriod { get; set; }
    }
}



