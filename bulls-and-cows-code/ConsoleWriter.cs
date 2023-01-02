namespace bulls_and_cows_code;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }

    public void Write(string text)
    {
        Console.Write(text);
    }
}