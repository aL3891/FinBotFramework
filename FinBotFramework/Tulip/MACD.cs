using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{
    /// <summary>
    /// Moving Average Convergence/Divergence
    /// </summary>
    [Keyless] 
    public class MACD
    {
        public Stock Stock { get; set; } 
        public string StockId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Macd { get; set; }
        public decimal Macd_signal { get; set; }
        public decimal Macd_histogram { get; set; }
        public decimal ShortPeriod { get; set; }
        public decimal LongPeriod { get; set; }
        public decimal SignalPeriod { get; set; }

        
        public async Task Calculate(BotContext context)
        {
            var indicator = Indicators.IndicatorsDefinition["macd"];
            var count = indicator.Start(new decimal[] {ShortPeriod, LongPeriod, SignalPeriod});

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
                output[i] = new decimal[3];
            }

            indicator.Run(input, new decimal[] {ShortPeriod, LongPeriod, SignalPeriod}, output);

            Macd = output[0][0];
Macd_signal = output[0][1];
Macd_histogram = output[0][2];
        }
    }
}
