

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Rate of Change Ratio
    /// </summary>
    [Keyless] 
    public class ROCR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Rocr { get; set; }
        public decimal Period { get; set; }
    }
}



