

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

namespace FinBotNet
{
    /// <summary>
    /// Average Directional Movement Rating
    /// </summary>
    [Keyless] 
    public class ADXR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Dx { get; set; }
        public decimal Period { get; set; }
    }
}



