using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

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
        public TimeSpan TimeSpan { get; set; }
        public decimal Msw_sine { get; set; }
        public decimal Msw_lead { get; set; }
        public decimal Period { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["msw"];
            var count = indicator.Start(new decimal[] {Period});

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
                output[i] = new decimal[2];
            }

            indicator.Run(input, new decimal[] {Period}, output);

            Msw_sine = output[0][0];
Msw_lead = output[0][1];
        }
    }
}
