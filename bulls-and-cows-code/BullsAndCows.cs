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
        _writer.Write("Welcome to Bulls and Cows!");
        
        var numberOfGuesses = 0;

        while (true)
        {
            _writer.Write("---");
            _writer.Write("You guess: ");
            
            var guess = _reader.Read();

            while (!_inputValidator.IsValidInput(guess))
            {
                _writer.Write("Invalid input. Please try again.");
                guess = _reader.Read();
            }

            if (_guessEvaluator.IsCorrectGuess(guess))
            {
                _writer.Write("You win!");
                break;
            }

            var numberOfBulls = _guessEvaluator.GetNumberOfBulls(guess);
            var numberOfCows = _guessEvaluator.GetNumberOfCows(guess);
            
            _writer.Write($"Result: {numberOfBulls} bull(s) and {numberOfCows} cow(s)");

            numberOfGuesses++;

            if (numberOfGuesses == MaxNumberOfGuesses)
            {
                _writer.Write("No guesses remaining, it's a tie!");
                break;
            }
        }
    }
}