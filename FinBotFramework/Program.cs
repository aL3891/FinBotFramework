using System;
using System.IO;
using System.Linq;
using Tulip;

namespace FinBotNet
{
    class Program
    {

        public static string ToProp(string input) => string.Join("", input.Replace("%", "").Split(' ').Select(n => Cap(n)));

        public static string Cap(string input) => input[0].ToString().ToUpper() + input.Substring(1);

        static void Main(string[] args)
        {
            GenerateTulipIndicators();
        }

        private static void GenerateTulipIndicators()
        {
            foreach (var item in Indicators.IndicatorsDefinition)
            {
                var fi = new FileInfo($@"..\..\..\Tulip\{item.Key.ToUpper()}.cs");

                var props = string.Join(Environment.NewLine, item.Value.Outputs.Concat(item.Value.Options).Select(p => $"        public decimal {ToProp(p)} {{ get; set; }}"));
                File.WriteAllText(fi.FullName, $@"using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;
using System.Threading.Tasks;
using Tulip;
using System.Linq;

namespace FinBotNet
{{
    /// <summary>
    /// {item.Value.FullName}
    /// </summary>
    [Keyless] 
    public class {item.Key.ToUpper()}
    {{
        public Stock Stock {{ get; set; }} 
        public string StockId {{ get; set; }}
        public DateTime Date {{ get; set; }}
        public TimeSpan TimeSpan {{ get; set; }}
{props}

        
        public async Task Calculate(BotContext context)
        {{
            var indicator = Indicators.IndicatorsDefinition[""{item.Key}""];
            var count = indicator.Start(new decimal[] {{{string.Join(", ", item.Value.Options.Select(p => ToProp(p)))}}});

            var inputLength = (int){(item.Value.Options.Contains("period") ? "Period" : "1")} + count;

            var price = await context.StockPrice
                .Where(s => s.StockId == StockId)
                .Where(s => s.Date < Date)
                .Where(s => s.TimeSpan == TimeSpan)
                .OrderByDescending(s => s.Date)
                .Take(inputLength)
                .ToArrayAsync();

            if (price.Length - count < 1)
                return;

            decimal[][] input = price.Select(c => new decimal[] {{ {string.Join(", ", item.Value.Inputs.Select(p => "c." + ToProp(p.Replace("real", "close"))))} }}).ToArray();
            decimal[][] output = new decimal[price.Length - count][];

            for (int i = 0; i < output.Length; i++)
            {{
                output[i] = new decimal[{item.Value.Outputs.Length}];
            }}

            indicator.Run(input, new decimal[] {{{string.Join(", ", item.Value.Options.Select(p => ToProp(p)))}}}, output);

            { string.Join(Environment.NewLine, item.Value.Outputs.Select((o, i) => ToProp(o) + " = output[0][" + i + "];"))}
        }}
    }}
}}
");
            }
        }
    }
}
