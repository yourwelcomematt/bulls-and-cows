namespace bulls_and_cows_code;

public class ConsoleWriter : IWriter
{
    public void Write(string text)
    {
        Console.WriteLine(text);
    }
}