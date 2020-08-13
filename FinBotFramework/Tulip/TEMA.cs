

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Triple Exponential Moving Average
    /// </summary>
    [Keyless] 
    public class TEMA
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Tema { get; set; }
        public decimal Period { get; set; }
    }
}



