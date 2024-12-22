using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Format
{
    [Command(name: "json", Description = "Format json format with indentation")]
    internal class FormatJsonCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var parsedJson = JsonConvert.DeserializeObject(text);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
    }
}
