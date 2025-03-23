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
    [Command(name: "rm-dup", Description = "重複行を削除する")]
    internal class RemoveDuplicateCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var buffer = new HashSet<string>();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() > -1)
                {
                    buffer.Add(reader.ReadLine());
                }
            }

            var outBuffer = new StringBuilder();
            outBuffer.AppendJoin('\n', buffer);

            return outBuffer.ToString();
        }
    }
}
