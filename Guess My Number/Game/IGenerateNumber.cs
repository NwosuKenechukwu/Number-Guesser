using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Game
{
    public interface IGenerateNumber
    {
        public int GeneratedNumber { get; }

        public string DescribeHowToPlay();

        public void GenerateNumber();


    }
}
