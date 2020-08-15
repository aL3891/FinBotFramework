using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Volume Oscillator
    /// </summary>
    [Keyless] 
    public class VOSC
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Vosc { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["vosc"];
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

            decimal[][] input = price.Select(c => new decimal[] { c.Volume }).ToArray();
            decimal[][] output = new decimal[price.Length - count][];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new decimal[1];
            }

            indicator.Run(input, new decimal[] {ShortPeriod, LongPeriod}, output);

            Vosc = output[0][0];
        }
    }
}
