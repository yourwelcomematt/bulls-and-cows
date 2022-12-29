using bulls_and_cows_code;

namespace bulls_and_cows_tests;

public class CodeGeneratorTests
{
    [Fact]
    public void GenerateCode_GeneratesACodeOfTheSpecifiedLength()
    {
        var codeLength = 4;
        var codeGenerator = new CodeGenerator(codeLength);

        var code = codeGenerator.GenerateCode();
        
        Assert.True(code.Length == codeLength);
    }
    
    [Fact]
    public void GenerateCode_GeneratesACodeThatConsistsOnlyOfDigits()
    {
        var codeLength = 4;
        var codeGenerator = new CodeGenerator(codeLength);

        var code = codeGenerator.GenerateCode();
        
        Assert.True(int.TryParse(code, out _));
    }
    
    [Fact]
    public void GenerateCode_GeneratesACodeThatConsistsOnlyOfUniqueDigits()
    {
        var codeLength = 4;
        var codeGenerator = new CodeGenerator(codeLength);

        var code = codeGenerator.GenerateCode();
        var containsDuplicateDigits = ContainsDuplicateDigits(code);
        
        Assert.False(containsDuplicateDigits);
    }

    private bool ContainsDuplicateDigits(string code)
    {
        var usedDigits = new Dictionary<char, int>();

        foreach (var digit in code)
        {
            if (!usedDigits.TryAdd(digit, 1))
            {
                return true;
            }
        }

        return false;
    }
}