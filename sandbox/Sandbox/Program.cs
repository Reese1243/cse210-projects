using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

class Program
{

    class Circle
    {
        private double _radius; // setting to private makes the data inaccessible normally

       public void SetRadius(double radius)
        {

            if(radius < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    static void Main(string[] args)
    {
        int sleepTime = 250;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(20);

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(sleepTime);
            Console.Write(".");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("o");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("O");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("0");
            Console.Write("\b");
        }

    }

    
}