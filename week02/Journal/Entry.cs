public class Entry
{
    public string _date;
    public string _promptText;
    public string _responseText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_responseText}");
        Console.WriteLine();
    }
}