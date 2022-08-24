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
                    Console.WriteLine(".OS v0.1");
                    Console.WriteLine("Made by Marko2155");
                }

                if (input == "help")
                {
                    Console.WriteLine("help - The command that shows this menu.");
                    Console.WriteLine("ver - Shows .OS version");
                    Console.WriteLine("shutdown - Shuts down the operating system");
                } else
                {
                    Console.WriteLine("Command not recognised.");
                }

                if (input == "shutdown")
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}