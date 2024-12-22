using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Formatting = System.Xml.Formatting;

namespace ClipboardTools.Commands.Format
{
    [Command(name: "xml", Description = "Format Xml format with indentation")]
    internal class FormatXmlCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            XDocument doc = XDocument.Parse(text);
            return doc.ToString();
        }
    }
}
