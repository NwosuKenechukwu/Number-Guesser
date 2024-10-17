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

        private int _testNumber = 10;

        public void GenerateNumber()
        {
            GeneratedNumber = _testNumber;
        }
    }
}
