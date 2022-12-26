namespace bulls_and_cows_code;

public class ConsoleReader : IReader
{
    public string? Read()
    {
        return Console.ReadLine();
    }
}