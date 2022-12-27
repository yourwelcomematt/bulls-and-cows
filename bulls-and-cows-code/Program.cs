using bulls_and_cows_code;

var consoleReader = new ConsoleReader();
var consoleWriter = new ConsoleWriter();
var codeLength = 4;
var inputValidator = new InputValidator(codeLength);
var codeGenerator = new CodeGenerator(codeLength);
var computerCode = codeGenerator.GenerateCode();
var guessEvaluator = new GuessEvaluator(computerCode);

var bullsAndCows = new BullsAndCows(consoleReader, consoleWriter, inputValidator, guessEvaluator);

bullsAndCows.Run();