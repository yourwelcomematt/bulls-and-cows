namespace bulls_and_cows_code;

public class CodeGenerator
{
    private int _codeLength;

    public CodeGenerator(int codeLength)
    {
        _codeLength = codeLength;
    }

    public string GenerateCode()
    {
        var random = new Random();
        var usedDigits = new Dictionary<int, int>();
        var code = "";

        for (var i = 0; i < _codeLength; i++)
        {
            var digit = random.Next(0, 10);

            while (usedDigits.ContainsKey(digit))
            {
                digit = random.Next(0, 10);
            }

            code += digit;
            usedDigits.Add(digit, 1);
        }
        
        return code;
    }
}