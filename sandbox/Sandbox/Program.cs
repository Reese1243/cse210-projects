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
        //Console.WriteLine("hi");
        Circle myCircle = new Circle();
        Circle myCircle2 = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");

        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetArea()}");

    }

    
}