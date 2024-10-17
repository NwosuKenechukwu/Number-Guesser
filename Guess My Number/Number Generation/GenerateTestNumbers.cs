using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Number_Generation
{
    public class GenerateTestNumbers : IGenerateNumber
    {
        public int GeneratedNumber { get; private set; }

        public int Min { get; set; } = 10;

        public int Max { get; set; } = 10;

        public void GenerateNumber()
        {
            GeneratedNumber = (Min + Max) / 2;
        }
    }
}
