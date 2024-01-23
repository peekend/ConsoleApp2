using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow((x+1/x-1),2) + 18*x*Math.Pow(y,2));
        }
    }
}
