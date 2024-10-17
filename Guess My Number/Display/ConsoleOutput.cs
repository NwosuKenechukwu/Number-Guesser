using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Display
{
    public class ConsoleOutput : IDisplayOutput
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
