

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Parabolic SAR
    /// </summary>
    [Keyless] 
    public class PSAR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Psar { get; set; }
        public decimal AccelerationFactorStep { get; set; }
        public decimal AccelerationFactorMaximum { get; set; }
    }
}



