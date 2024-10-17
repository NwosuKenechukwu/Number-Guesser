using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_My_Number.Game;

namespace Guess_My_Number.Display
{
    public class ConsoleInput : IPlayerInput
    {
        public int Read()
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            return UserInput;
        }
    }
}
