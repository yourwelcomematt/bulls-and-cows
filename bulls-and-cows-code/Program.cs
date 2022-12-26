using bulls_and_cows_code;

var consoleReader = new ConsoleReader();
var consoleWriter = new ConsoleWriter();
var inputValidator = new InputValidator();
var computerCode = "1234";
var guessEvaluator = new GuessEvaluator(computerCode);

var bullsAndCows = new BullsAndCows(consoleReader, consoleWriter, inputValidator, guessEvaluator);

bullsAndCows.Run();