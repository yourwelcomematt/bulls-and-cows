namespace bulls_and_cows_code;

public class InputValidator
{
    private readonly int _codeLength;

    public InputValidator(int codeLength)
    {
        _codeLength = codeLength;
    }

    public bool IsValidInput(string input)
    {
        if (!(int.TryParse(input, out _) && input.Length == _codeLength))
        {
            return false;
        }

        var usedDigits = new Dictionary<char, int>();

        foreach (var digit in input)
        {
            if (usedDigits.ContainsKey(digit))
            {
                return false;
            }
            
            usedDigits.Add(digit, 1);
        }

        return true;
    }
}