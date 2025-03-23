using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClipboardTools.Commands.EncodeDecode
{
    [HelpOption("--help|-h")]
    [Command(name: "samlres-d", Description = "SAMLリクエストパラメーターをデコードして整形します。")]
    internal class SamlDecodeCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            try
            {
                var decodedXml = Encoding.UTF8.GetString(System.Convert.FromBase64String(text));

                // XMLを整形して返す
                var doc = new XmlDocument();
                doc.LoadXml(decodedXml);

                var sb = new StringBuilder();
                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  ",
                    NewLineChars = Environment.NewLine,
                    NewLineHandling = NewLineHandling.Replace
                };

                using (var writer = XmlWriter.Create(sb, settings))
                {
                    doc.Save(writer);
                }

                return sb.ToString();
            }
            catch (FormatException)
            {
                return null;
            }
            catch (XmlException)
            {
                // XMLとして解析できない場合は、単純にデコードしたテキストを返す
                return Encoding.UTF8.GetString(System.Convert.FromBase64String(text));
            }
        }
    }
}
