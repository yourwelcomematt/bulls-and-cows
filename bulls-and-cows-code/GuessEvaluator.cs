namespace bulls_and_cows_code;

public class GuessEvaluator
{
    private readonly string _computerCode;

    public GuessEvaluator(string computerCode)
    {
        _computerCode = computerCode;
    }

    public bool IsCorrectGuess(string guess)
    {
        return _computerCode == guess;
    }

    public int GetNumberOfBulls(string guess)
    {
        var numberOfBulls = 0;

        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == _computerCode[i])
            {
                numberOfBulls++;
            }
        }

        return numberOfBulls;
    }
    
    public int GetNumberOfCows(string guess)
    {
        var numberOfCows = 0;
        
        for (int i = 0; i < guess.Length; i++)
        {
            var indexOfGuessDigitInComputerCode = _computerCode.IndexOf(guess[i]);
            
            if (indexOfGuessDigitInComputerCode != i && indexOfGuessDigitInComputerCode != -1)
            {
                numberOfCows++;
            }
        }

        return numberOfCows;
    }
}