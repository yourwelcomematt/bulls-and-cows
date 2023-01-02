using bulls_and_cows_code;
using NSubstitute;

namespace bulls_and_cows_tests;

public class BullsAndCowsTests
{
    [Fact]
    public void GivenTheGameIsRun_WhenThePlayerGuessesTheCorrectCode_ThenTheyWin()
    {
        var mockWriter = Substitute.For<IWriter>();
        var mockReader = Substitute.For<IReader>();
        mockReader.Read().Returns("1234");

        var inputValidator = new InputValidator(4);
        var guessEvaluator = new GuessEvaluator("1234");

        var bullsAndCows = new BullsAndCows(mockReader, mockWriter, inputValidator, guessEvaluator);
        
        bullsAndCows.Run();
        
        mockWriter.Received(1).WriteLine("You win!");
    }
    
    [Fact]
    public void GivenTheGameIsRun_WhenThePlayerExceedsTheMaximumNumberOfGuesses_ThenTheGameEnds()
    {
        var mockWriter = Substitute.For<IWriter>();
        var mockReader = Substitute.For<IReader>();
        mockReader.Read().Returns("0234");

        var inputValidator = new InputValidator(4);
        var guessEvaluator = new GuessEvaluator("1234");

        var bullsAndCows = new BullsAndCows(mockReader, mockWriter, inputValidator, guessEvaluator);
        
        bullsAndCows.Run();
        
        mockWriter.Received(1).WriteLine("No guesses remaining, it's a tie!");
    }
}