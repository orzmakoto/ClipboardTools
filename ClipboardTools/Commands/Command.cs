using ClipboardTools.Commands.Convert;
using ClipboardTools.Commands.Edit;
using ClipboardTools.Commands.EncodeDecode;
using ClipboardTools.Commands.Format;
using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands
{
    [HelpOption("--help|-h")]
    [Command(name: "clipboardtools", Description = "ClipboardTools")]
    [Subcommand(
        typeof(ShowCommand),
        typeof(ConvertMdTableCommand),
        typeof(Base64EncodeCommand),
        typeof(Base64DecodeCommand),
        typeof(SamlDecodeCommand),
        typeof(JsonFormatCommand),
        typeof(XmlFormatCommand),
        typeof(SortCommand)
        )]
    internal class Command
    {
        public int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return 0;
        }
    }
}
