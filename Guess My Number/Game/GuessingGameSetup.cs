using Guess_My_Number.Display;
using Guess_My_Number.Number_Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Game
{
    public class GuessingGameSetup : IGameSetup
    {
        private IDisplayOutput _displayOutput;
        private IGenerateNumber _generateNumber;
        private IGameLogic _logic;

        public GuessingGameSetup(IDisplayOutput displayOutput, IGenerateNumber generateNumber, IGameLogic logic)
        {
            _displayOutput = displayOutput;
            _generateNumber = generateNumber;
            _logic = logic;
        }

        public void Init()
        {
            _displayOutput.Write("Guess a number between " + _generateNumber.Min + " and " + _generateNumber.Max);
            _generateNumber.GenerateNumber();
            _logic.checkGameState();
        }
    }
}
