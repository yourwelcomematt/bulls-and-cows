using bulls_and_cows_code;

namespace bulls_and_cows_tests;

public class GuessEvaluatorTests
{
    private readonly GuessEvaluator _guessEvaluator = new ("1234");
    
    [Fact]
    public void IsCorrectGuess_ReturnsTrue_WhenTheGuessMatchesTheCode()
    {
        var actual = _guessEvaluator.IsCorrectGuess("1234");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void IsCorrectGuess_ReturnsFalse_WhenTheGuessDoesNotMatchTheCode()
    {
        var actual = _guessEvaluator.IsCorrectGuess("0234");
        
        Assert.False(actual);
    }

    [Theory]
    [InlineData("5678", 0)]
    [InlineData("0289", 1)]
    [InlineData("1243", 2)]
    public void GetNumberOfBulls_ReturnsTheCorrectNumberOfBulls_WhenPassedAGivenGuess(string guess, int expected)
    {
        var actual = _guessEvaluator.GetNumberOfBulls(guess);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("6789", 0)]
    [InlineData("7891", 1)]
    [InlineData("1923", 2)]
    public void GetNumberOfCows_ReturnsTheCorrectNumberOfCows_WhenPassedAGivenGuess(string guess, int expected)
    {
        var actual = _guessEvaluator.GetNumberOfCows(guess);
        
        Assert.Equal(expected, actual);
    }
}