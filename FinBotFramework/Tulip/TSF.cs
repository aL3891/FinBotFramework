

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Time Series Forecast
    /// </summary>
    [Keyless] 
    public class TSF
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Tsf { get; set; }
        public decimal Period { get; set; }
    }
}



