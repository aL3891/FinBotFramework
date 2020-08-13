

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Percentage Price Oscillator
    /// </summary>
    [Keyless] 
    public class PPO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Ppo { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
    }
}



