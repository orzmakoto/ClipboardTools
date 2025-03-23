using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands
{
    [HelpOption("--help|-h")]
    [Command(name: "save", Description = "クリップボード上のテキストをダウンロードフォルダに保存する")]
    internal class SaveCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            File.AppendAllText(Path.Combine(downloadsPath, $"clipboard_{DateTime.Now:yyyyMMdd_HHmmss}.{DetectFormat(text)}"), text);

            return null;
        }
        private string DetectFormat(string text)
        {
            if (IsJson(text))
                return "json";
            if (IsXml(text))
                return "xml";
            if (IsCsv(text))
                return "csv";
            if (IsTsv(text))
                return "tsv";

            return "txt";
        }

        private bool IsJson(string text)
        {
            text = text.Trim();
            return (text.StartsWith("{") && text.EndsWith("}")) || (text.StartsWith("[") && text.EndsWith("]"));
        }

        private bool IsXml(string text)
        {
            text = text.Trim();
            return text.StartsWith("<") && text.EndsWith(">");
        }

        private bool IsCsv(string text)
        {
            return GetFirstLine(text).Contains(",");
        }

        private bool IsTsv(string text)
        {
            return GetFirstLine(text).Contains("\t");
        }
        private string GetFirstLine(string text)
        {
            using (var reader = new StringReader(text))
            {
                return reader.ReadLine();
            }
        }
    }
}
