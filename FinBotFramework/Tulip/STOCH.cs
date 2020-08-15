using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Stochastic Oscillator
    /// </summary>
    [Keyless] 
    public class STOCH
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Stoch_k { get; set; }
        public decimal Stoch_d { get; set; }
        public decimal KPeriod { get; set; }
        public decimal KSlowingPeriod { get; set; }
        public decimal DPeriod { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["stoch"];
            var count = indicator.Start(new decimal[] {KPeriod, KSlowingPeriod, DPeriod});

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

            decimal[][] input = price.Select(c => new decimal[] { c.High, c.Low, c.Close }).ToArray();
            decimal[][] output = new decimal[price.Length - count][];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new decimal[2];
            }

            indicator.Run(input, new decimal[] {KPeriod, KSlowingPeriod, DPeriod}, output);

            Stoch_k = output[0][0];
Stoch_d = output[0][1];
        }
    }
}
