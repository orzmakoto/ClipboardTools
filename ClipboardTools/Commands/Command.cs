using ClipboardTools.Commands.Convert;
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
    [Command]
    [Subcommand(
        typeof(FormatCommand),
        typeof(ConvertCommand),
        typeof(ShowCommand)
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
