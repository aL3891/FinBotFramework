

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Vector Division
    /// </summary>
    [Keyless] 
    public class DIV
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Div { get; set; }
    }
}



