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
    [Command(name: "to-mdtable", Description = "CSVもしくはTSV形式のテキストをMarkdownテーブルに変換する")]
    internal class ConvertMdTableCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var delimiter = ",";
            using (var reader = new StringReader(text))
            {
                var headerLine = reader.ReadLine();
                if (headerLine?.Contains("\t") == true)
                {
                    delimiter = "\t";
                }
            }
            
            var sourceDatas = new List<List<string>>();
            var config = new CsvConfiguration(new CultureInfo("ja-JP", false));
            config.HasHeaderRecord = false;
            config.Delimiter = delimiter;
            using (var csv = new CsvReader(new StringReader(text), config))
            {
                while (csv.Read())
                {
                    sourceDatas.Add((csv.GetRecord<dynamic>() as IDictionary<string, object>).Values.Select(i => i.ToString()).ToList());
                }
            }

            var mdTableString = new StringBuilder();

            foreach (var data in sourceDatas)
            {
                var rowString = $"| {string.Join(" | ", data)} |";
                if (mdTableString.Length == 0)
                {
                    mdTableString.AppendLine(rowString);
                    mdTableString.AppendLine($"| {string.Join(" | ", Enumerable.Repeat("---", data.Count).ToArray())} |");
                }
                else
                {
                    mdTableString.AppendLine(rowString);
                }
            }

            return mdTableString.ToString();
        }
    }
}
