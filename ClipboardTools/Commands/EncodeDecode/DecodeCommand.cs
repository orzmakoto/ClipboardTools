using ClipboardTools.Commands.Format;
using McMaster.Extensions.CommandLineUtils;

namespace ClipboardTools.Commands.Convert
{
    [HelpOption("--help|-h")]
    [Command(name: "decode")]
    [Subcommand(
        typeof(DecodeBase64Command)
    )]
    internal class DecodeCommand
    {
        public int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return 0;
        }
    }
}
