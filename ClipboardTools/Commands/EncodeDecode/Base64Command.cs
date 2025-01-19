using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Format
{
    [Command(name: "base64", Description = "")]
    internal class EncodeBase64Command : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }
    [Command(name: "base64", Description = "")]
    internal class DecodeBase64Command : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            return Encoding.UTF8.GetString(System.Convert.FromBase64String(text));
        }
    }
}
