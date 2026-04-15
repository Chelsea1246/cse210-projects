using System;
using System.Collections.Generic;
namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> tracker = new List<Activity>();

            tracker.Add(new Running("03 Nov 2022", 30, 4.8));
            tracker.Add(new Cycling("04 Nov 2022", 45, 20));
            tracker.Add(new Swimming("05 Nov 2022", 60, 30));

            foreach (Activity activity in tracker)
            {
                Console.WriteLine(activity.GetSummary());
            }   
        }
    }
}