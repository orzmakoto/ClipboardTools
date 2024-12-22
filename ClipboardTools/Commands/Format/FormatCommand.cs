using McMaster.Extensions.CommandLineUtils;

namespace ClipboardTools.Commands.Format
{
    [HelpOption("--help|-h")]
    [Command(name: "format")]
    [Subcommand(
    typeof(FormatJsonCommand),
    typeof(FormatXmlCommand)
    )]
    internal class FormatCommand
    {
        public int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return 0;
        }
    }
}
