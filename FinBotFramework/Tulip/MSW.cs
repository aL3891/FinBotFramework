

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Mesa Sine Wave
    /// </summary>
    [Keyless] 
    public class MSW
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Msw_sine { get; set; }
        public decimal Msw_lead { get; set; }
        public decimal Period { get; set; }
    }
}



