
using Guess_My_Number.Game;
using Guess_My_Number.Display;
using Guess_My_Number.Number_Generation;

public class Application
{
    static void Main()
    {
        Application.Run();
    }

    static void Run()
    {
        IDisplayOutput displayOutput = new ConsoleOutput();
        IDisplayInput displayInput = new ConsoleInput();
        IGenerateNumber generateNumber = new GenerateRandomNumbers();
        IGameLogic logic = new GuessingGameLogic(displayInput, displayOutput, generateNumber);

        GuessingGameSetup newGame = new GuessingGameSetup(displayOutput, generateNumber, logic);

        newGame.Init();
    }
}
