class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
              "This activity will help you relax by guiding your breathing.")
    { }

    public void Run()
    {
        Start();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);

            Console.WriteLine("Breathe out...");
            Pause(3);

            elapsed += 6;
        }

        End();
    }
}