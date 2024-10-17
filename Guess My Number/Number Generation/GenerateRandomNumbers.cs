using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Number_Generation
{
    public class GenerateRandomNumbers : IGenerateNumber
    {
        public int GeneratedNumber { get; private set; }

        public int Min { get; set; }
        public int Max { get; set; }

        public GenerateRandomNumbers(int min, int max) {
            Min = min;
            Max = max;
        }

        public void GenerateNumber()
        {
            GeneratedNumber = new Random().Next(Min, Max);
        }
    }
}