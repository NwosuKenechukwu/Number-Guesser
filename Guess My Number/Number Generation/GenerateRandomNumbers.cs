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

        private int _min = 0;
        private int _max = 100;

        public void GenerateNumber()
        {
            GeneratedNumber = new Random().Next(_min, _max);
        }
    }
}