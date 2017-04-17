using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" " + "Hello, Please enter a string of words. \n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string words = Console.ReadLine();
            Console.WriteLine("\n");
            Console.ResetColor();

            string resultString = string.Join(" ", words
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------");
            Console.WriteLine(" " + "Reversed String");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" " + resultString + "\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
