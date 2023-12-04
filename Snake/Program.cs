using System;
using System.Collections.Generic;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] DirectionChars = ['^', 'v', '<', '>',];
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            string prompt = $"Press any key to start...";
            Console.Write(prompt);
            Console.ReadKey(true);
            Console.Clear();

        }

    }

}