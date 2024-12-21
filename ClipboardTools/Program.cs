using ClipboardTools.Commands;
using McMaster.Extensions.CommandLineUtils;
using System.Text;

namespace ClipboardTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args = new string[] {
                "xmlf"
            };
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            CommandLineApplication.Execute<Command>(args);
        }
    }
}
