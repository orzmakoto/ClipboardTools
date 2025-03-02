using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Edit
{
    [HelpOption("--help|-h")]
    [Command(name: "sort", Description = "並び替えをする（既定の並び順は、昇順）")]
    internal class SortCommand : CommandBase
    {
        [Option(ShortName = "d",Description ="降順で並び替えをする")]
        public bool Desc { get; set; }
        protected override string InnerExecute(string text)
        {
            var buffer = new List<string>();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() > -1)
                {
                    buffer.Add(reader.ReadLine());
                }
            }

            var outBuffer = new StringBuilder();
            outBuffer.AppendJoin('\n', Desc ? buffer.OrderDescending() : buffer.Order());


            return outBuffer.ToString();
        }
    }
}
