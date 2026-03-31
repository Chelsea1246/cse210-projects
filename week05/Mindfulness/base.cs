class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"\n--- {_name} ---");
        Console.WriteLine(_description);

        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        Pause(2);

        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "...");
            Thread.Sleep(1000);
            Console.Write("\r        \r");
        }
    }

    protected void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\r");
        }
    }
}