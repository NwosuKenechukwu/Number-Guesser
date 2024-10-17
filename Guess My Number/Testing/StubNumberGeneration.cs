using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_My_Number.Game;

namespace Guess_My_Number.Testing
{
    public class StubNumberGeneration : IGenerateNumber
    {
        public int GeneratedNumber { get; set; } = 10;

        public string DescribeHowToPlay()
        {
            return "This is a stub!";
        }

        public void GenerateNumber()
        {
            // No Action
        }
    }
}
