using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Display
{
    public class ConsoleInput : IDisplayInput
    {
        public int Read()
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            return UserInput;
        }
    }
}
