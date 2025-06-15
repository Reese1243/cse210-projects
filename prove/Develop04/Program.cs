using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListActivity listActivity = new ListActivity("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        int menuSelect = 0;

        while (menuSelect != 4)
        {
            string useInput = Console.ReadLine();
            menuSelect = int.Parse(useInput);

            switch (menuSelect)
            {
                case 1:
                    breathingActivity.BreathTimerCountdown();
                    break;
                
                
                case 2:
                    reflectionActivity.ReflectionTimerCountDown();
                    break;
                

                case 3:
                    listActivity.ListActivityCountDown();
                    break;


            }
        }
    }
}