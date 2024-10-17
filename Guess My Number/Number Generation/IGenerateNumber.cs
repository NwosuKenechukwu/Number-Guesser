using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Number_Generation
{
    public interface IGenerateNumber
    {
        public int GeneratedNumber { get; }

        public void GenerateNumber();


    }
}
