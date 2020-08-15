using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Bollinger Bands
    /// </summary>
    [Keyless] 
    public class BBANDS
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Bbands_lower { get; set; }
        public decimal Bbands_middle { get; set; }
        public decimal Bbands_upper { get; set; }
        public decimal Period { get; set; }
        public decimal Stddev { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["bbands"];
            var count = indicator.Start(new decimal[] {Period, Stddev});

            var inputLength = (int)Period + count;

            var price = await context.StockPrice
                .Where(s => s.StockId == StockId)
                .Where(s => s.Date < Date)
                .Where(s => s.TimeSpan == TimeSpan)
                .OrderByDescending(s => s.Date)
                .Take(inputLength)
                .ToArrayAsync();

            if (price.Length - count < 1)
                return;

            decimal[][] input = price.Select(c => new decimal[] { c.Close }).ToArray();
            decimal[][] output = new decimal[price.Length - count][];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new decimal[3];
            }

            indicator.Run(input, new decimal[] {Period, Stddev}, output);

            Bbands_lower = output[0][0];
Bbands_middle = output[0][1];
Bbands_upper = output[0][2];
        }
    }
}
