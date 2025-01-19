using ClipboardTools.Commands.Format;
using McMaster.Extensions.CommandLineUtils;

namespace ClipboardTools.Commands.Convert
{
    [HelpOption("--help|-h")]
    [Command(name: "encode")]
    [Subcommand(
        typeof(EncodeBase64Command)
    )]
    internal class EncodeCommand
    {
        public int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return 0;
        }
    }
}
