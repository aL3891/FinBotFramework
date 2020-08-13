using System;
using System.IO;
using System.Linq;
using Tulip;

namespace FinBotNet
{
    class Program
    {

        public static string ToProp(string input) => string.Join("", input.Replace("%","").Split(' ').Select(n => Cap(n)));

        public static string Cap(string input) => input[0].ToString().ToUpper() + input.Substring(1);

        static void Main(string[] args)
        {
            foreach (var item in Indicators.IndicatorsDefinition)
            {
                var fi = new FileInfo($@"..\..\..\Indicators2\{item.Key.ToUpper()}.cs");

                var props = string.Join(Environment.NewLine, item.Value.Outputs.Concat(item.Value.Options).Select(p => $"        public decimal {ToProp(p)} {{ get; set; }}"));
                File.WriteAllText(fi.FullName, $@"

using Microsoft.EntityFrameworkCore; 
using System;
using FinBotNet;

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
{props}
    }}
}}



");

            }


        }
    }
}
