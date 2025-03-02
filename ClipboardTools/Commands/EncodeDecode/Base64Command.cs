using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Format
{
    [HelpOption("--help|-h")]
    [Command(name: "base64e", Description = "文字列をBase64でエンコードする")]
    internal class Base64EncodeCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }

    [HelpOption("--help|-h")]
    [Command(name: "base64d", Description = "Base64でエンコードされた文字列をデコードする")]
    internal class Base64DecodeCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            return Encoding.UTF8.GetString(System.Convert.FromBase64String(text));
        }
    }
}
