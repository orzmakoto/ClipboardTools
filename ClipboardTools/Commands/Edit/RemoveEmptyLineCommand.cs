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
    [Command(name: "rm-emptyline", Description = "空行を削除する")]
    internal class RemoveEmptyLineCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var outBuffer = new StringBuilder();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() > -1)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line) == false)
                    {
                        outBuffer.AppendLine(line);
                    }
                }
            }

            return outBuffer.ToString();
        }
    }
}
