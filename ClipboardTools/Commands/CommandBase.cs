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

        [Option(ShortName = "s", Description = "実行結果をクリップボードに格納せずに標準出力する")]
        public bool Show { get; set; } = false;

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
                if (Show)
                {
                    Console.Write(resultText);
                }
                else
                {
                    ClipboardService.SetText(resultText);
                }
            }
            return 0;
        }
    }
}
