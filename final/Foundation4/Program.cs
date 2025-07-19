using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly date = new DateOnly(2025, 8, 17);
        ActivityRunning running = new ActivityRunning(3, date, 120);
        ActivityCycle cycle = new ActivityCycle(6.25, date, 75);
        ActivitySwimming swimming = new ActivitySwimming(15, date, 95);
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycle);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }

    }
}