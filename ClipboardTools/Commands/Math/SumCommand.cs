using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Math
{
    [HelpOption("--help|-h")]
    [Command(name: "math-sum", Description = "合計値を算出する")]
    internal class SumCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var buffer = new HashSet<decimal>();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() > -1)
                {
                    var val = reader.ReadLine();
                    try
                    {
                        buffer.Add(System.Convert.ToDecimal(val));

                    }
                    catch { }
                    
                }
            }
            return buffer.Sum().ToString();
        }
    }
}
