class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "How did you feel afterward?",
        "What did you learn?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
              "Reflect on times you showed strength and resilience.")
    { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Pause(3);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("> " + question);

            Spinner(3);
            elapsed += 3;
        }

        End();
    }
}