using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTools.Commands
{
    [Command(name: "show", Description = "Displays the text on the clipboard")]
    internal class ShowCommand : CommandBase
    {
        protected override string InnerExecute(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
            return null;
        }
    }
}
