using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .OS 1.0!");
            bool done = false;
            while (!done)
            {
                string input = Console.ReadLine();

                if (input == "ver")
                {
                    Console.WriteLine(".OS v1.0");
                    Console.WriteLine("Made by Marko2155");
                } else if (input == "help")
                {
                    Console.WriteLine("help - The command that shows this menu.");
                    Console.WriteLine("ver - Shows .OS version");
                    Console.WriteLine("shutdown - Shuts down the operating system");
                } else if (input == "shutdown")
                {
                    Environment.Exit(1);
                } else if (input == "echo") {
                    string echo = Console.ReadLine();
                    Console.WriteLine(echo);
                } else if (input == "clear") {
                    Console.Clear();
               } else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}