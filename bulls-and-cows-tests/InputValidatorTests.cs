using bulls_and_cows_code;

namespace bulls_and_cows_tests;

public class InputValidatorTests
{
    private readonly InputValidator _inputValidator = new(4);
    
    [Theory]
    [InlineData("0123")]
    [InlineData("6782")]
    public void IsValidInput_ReturnsTrue_WhenInputIsValid(string input)
    {
        var actual = _inputValidator.IsValidInput(input);
        
        Assert.True(actual);
    }
    
    [Theory]
    [InlineData("012")]
    [InlineData("0012")]
    [InlineData("01234")]
    [InlineData("aaaa")]
    [InlineData("$%^&*")]
    [InlineData("")]
    [InlineData(" ")]
    public void IsValidInput_ReturnsFalse_WhenInputIsInvalid(string input)
    {
        var actual = _inputValidator.IsValidInput(input);
        
        Assert.False(actual);
    }
}