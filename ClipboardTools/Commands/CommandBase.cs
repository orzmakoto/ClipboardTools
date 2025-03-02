using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCopy;

namespace ClipboardTools.Commands
{
    [HelpOption("--help")]
    public abstract class CommandBase
    {
        protected abstract string InnerExecute(string text);

        public int OnExecute()
        {
            var text = ClipboardService.GetText();
            if (string.IsNullOrEmpty(text) == true)
            {
                return 0;
            }
            var resultText = "";
            try
            {
                resultText = InnerExecute(text);
            }
            catch { }
            if (string.IsNullOrEmpty(resultText) == false)
            {
                ClipboardService.SetText(resultText);
            }
            return 0;
        }
    }
}
