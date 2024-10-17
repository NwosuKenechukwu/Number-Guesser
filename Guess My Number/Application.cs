
using Guess_My_Number.Game;
using Guess_My_Number.Display;
using Guess_My_Number.Number_Generation;

public class Application
{
    static void Main()
    {
        new Application().Run();
    }

    void Run()
    {
        IDisplayOutput displayOutput = new ConsoleOutput();
        IPlayerInput displayInput = new ConsoleInput();
        IGenerateNumber generateNumber = new GenerateRandomNumbers(0, 10);
        GuessMyNumberGame game = new GuessMyNumberGame(displayInput, displayOutput, generateNumber);

        game.Play();
    }
}
