using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Parabolic SAR
    /// </summary>
    [Keyless] 
    public class PSAR
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Psar { get; set; }
        public decimal AccelerationFactorStep { get; set; }
        public decimal AccelerationFactorMaximum { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["psar"];
            var count = indicator.Start(new decimal[] {AccelerationFactorStep, AccelerationFactorMaximum});

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

            decimal[][] input = price.Select(c => new decimal[] { c.High, c.Low }).ToArray();
            decimal[][] output = new decimal[price.Length - count][];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = new decimal[1];
            }

            indicator.Run(input, new decimal[] {AccelerationFactorStep, AccelerationFactorMaximum}, output);

            Psar = output[0][0];
        }
    }
}
