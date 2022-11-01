using System;

namespace Replay2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            if(name!=" ")
            {
                Console.WriteLine("Helow " + name);
            }
            else
            {
                Console.WriteLine("Hellow");
            }
        }
    }
}
