using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guess_My_Number.Display;
using Guess_My_Number.Number_Generation;

namespace Guess_My_Number.Game
{
    public class GuessingGameLogic : IGameLogic
    {
        private int _numberOfAttempts = 5;
        private int _userInput;

        private IDisplayInput _displayInput;
        private IDisplayOutput _displayOutput;
        private IGenerateNumber _generateNumber;
        public GuessingGameLogic(IDisplayInput displayInput ,IDisplayOutput displayOutput, IGenerateNumber generateNumber)
        {
            _displayInput = displayInput;
            _displayOutput = displayOutput;
            _generateNumber = generateNumber;
        }

        public void checkGameState()
        {
            gameLoop();
        }

        public void gameLoop()
        {
            while (numbersNotMatched() && _numberOfAttempts > 0)
            {
                try
                {
                    _userInput = Int32.Parse(Console.ReadLine());

                    if (numbersNotMatched())
                    {
                        updateGameState();
                        if (_numberOfAttempts == 0) { _displayOutput.Write("You got it wrong and have ran out of guesses. Better Luck next time!"); break; }
                        _displayOutput.Write(wrongMatchMessage(_userInput));
                    }
                    else if (!numbersNotMatched())
                    {
                        _displayOutput.Write("You guessed the correct number");
                    } else
                    {
                        updateGameState();
                        _displayOutput.Write(wrongMatchMessage(_userInput));
                    }
                }
                catch (FormatException) { 
                    _displayOutput.Write("Please enter a number to continue playing.");
                    continue;
                }
            }
        }

        private string wrongMatchMessage(int guess)
        {
            return guess < _generateNumber.GeneratedNumber ? "Too low. You have " + _numberOfAttempts + " attempts left."  : "Too High. You have " + _numberOfAttempts + " attempts left.";
        }

        private bool numbersNotMatched()
        {
            return _userInput != _generateNumber.GeneratedNumber;
        }

        public void updateGameState()
        {
            _numberOfAttempts--;
        }
    }
}
