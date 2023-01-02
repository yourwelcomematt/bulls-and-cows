namespace bulls_and_cows_code;

public class BullsAndCows
{
    private readonly IReader _reader;
    private readonly IWriter _writer;
    private readonly InputValidator _inputValidator;
    private readonly GuessEvaluator _guessEvaluator;
    private const int MaxNumberOfGuesses = 7;

    public BullsAndCows(IReader reader, IWriter writer, InputValidator inputValidator, GuessEvaluator guessEvaluator)
    {
        _reader = reader;
        _writer = writer;
        _inputValidator = inputValidator;
        _guessEvaluator = guessEvaluator;
    }

    public void Run()
    {
        _writer.WriteLine("Welcome to Bulls and Cows!");
        
        var numberOfGuesses = 0;

        while (true)
        {
            PrintNumberOfGuessesRemaining(numberOfGuesses);

            var guess = GetUserGuess();

            if (_guessEvaluator.IsCorrectGuess(guess))
            {
                _writer.WriteLine("You win!");
                break;
            }

            var numberOfBulls = _guessEvaluator.GetNumberOfBulls(guess);
            var numberOfCows = _guessEvaluator.GetNumberOfCows(guess);
            
            _writer.WriteLine($"Result: {numberOfBulls} bull(s) and {numberOfCows} cow(s)");

            numberOfGuesses++;

            if (numberOfGuesses == MaxNumberOfGuesses)
            {
                PrintTiedGameMessage();
                break;
            }
        }
        
        _writer.WriteLine("---");
        _writer.WriteLine("Thanks for playing!");
    }

    private void PrintNumberOfGuessesRemaining(int numberOfGuesses)
    {
        var numberOfGuessesRemaining = MaxNumberOfGuesses - numberOfGuesses;
        var guessForm = numberOfGuessesRemaining == 1 ? "guess" : "guesses";

        _writer.WriteLine("---");
        _writer.WriteLine($"{numberOfGuessesRemaining} {guessForm} remaining: ");
    }

    private string GetUserGuess()
    {
        var guess = _reader.Read();

        while (!_inputValidator.IsValidInput(guess))
        {
            _writer.WriteLine("Invalid input. Please try again.");
            guess = _reader.Read();
        }

        return guess;
    }

    private void PrintTiedGameMessage()
    {
        _writer.WriteLine("---");
        _writer.WriteLine("No guesses remaining, it's a tie!");
        _writer.WriteLine($"The code was {_guessEvaluator.ComputerCode}");
    }
}