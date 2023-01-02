namespace bulls_and_cows_code;

public class GuessEvaluator
{
    public string ComputerCode { get; }

    public GuessEvaluator(string computerCode)
    {
        ComputerCode = computerCode;
    }

    public bool IsCorrectGuess(string guess)
    {
        return ComputerCode == guess;
    }

    public int GetNumberOfBulls(string guess)
    {
        var numberOfBulls = 0;

        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == ComputerCode[i])
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
            var indexOfGuessDigitInComputerCode = ComputerCode.IndexOf(guess[i]);
            
            if (indexOfGuessDigitInComputerCode != i && indexOfGuessDigitInComputerCode != -1)
            {
                numberOfCows++;
            }
        }

        return numberOfCows;
    }
}