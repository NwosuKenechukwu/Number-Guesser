using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_My_Number.Game;

namespace Guess_My_Number.Number_Generation
{
    public class GenerateRandomNumbers : IGenerateNumber
    {
        public int GeneratedNumber { get; private set; }

        private int _min;
        private int _max;

        public GenerateRandomNumbers(int min, int max) {
            _min = min;
            _max = max;
        }

        public void GenerateNumber()
        {
            GeneratedNumber = new Random().Next(_min, _max);
        }

        public string DescribeHowToPlay()
        {
            return "Guess a number between " + _min + " and " + _max;
        }
    }
}