using CsvHelper.Configuration;
using CsvHelper;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClipboardTools.Commands.Convert
{
    [HelpOption("--help|-h")]
    [Command(name: "to-lower", Description = "文字列を小文字に変換する")]
    internal class ConvertLowerCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            return text.ToLower();
        }
    }
}
