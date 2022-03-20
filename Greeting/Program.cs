using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if(name != "") Console.WriteLine($"Konichiwa Uwu, {name}");
            else Console.WriteLine("You had to enter a name...");
            Console.Read();
        }
    }
}
