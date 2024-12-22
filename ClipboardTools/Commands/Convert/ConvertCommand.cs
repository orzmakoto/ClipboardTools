using McMaster.Extensions.CommandLineUtils;

namespace ClipboardTools.Commands.Convert
{
    [HelpOption("--help|-h")]
    [Command(name: "convert")]
    [Subcommand(
        typeof(ConvertMdTableCommand)
    )]
    internal class ConvertCommand
    {
        public int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return 0;
        }
    }
}
