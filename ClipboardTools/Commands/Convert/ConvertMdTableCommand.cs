using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands.Convert
{
    [Command(name: "tomdtable", Description = "Format json format with indentation")]
    internal class ConvertMdTableCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            var lines = new List<string>();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() > -1)
                {
                    //一行読み込んで表示する
                    lines.Add(reader.ReadLine());
                }
            }
            if (lines.Count == 0)
            {
                return null;
            }

            var header = lines.First();
            if(header.Contains("\t") == true)
            {

            }
            else if (header.Contains(",") == true)
            {

            }



            return null;
        }
    }
}
