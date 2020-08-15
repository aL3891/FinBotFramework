using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Percentage Price Oscillator
    /// </summary>
    [Keyless] 
    public class PPO
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Ppo { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["ppo"];
            var count = indicator.Start(new decimal[] {ShortPeriod, LongPeriod});

            var inputLength = (int)1 + count;

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
                output[i] = new decimal[1];
            }

            indicator.Run(input, new decimal[] {ShortPeriod, LongPeriod}, output);

            Ppo = output[0][0];
        }
    }
}
