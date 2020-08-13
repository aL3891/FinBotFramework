

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Rate of Change
    /// </summary>
    [Keyless] 
    public class ROC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Roc { get; set; }
        public decimal Period { get; set; }
    }
}



