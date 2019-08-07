using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character/symbol:");
            string char1 = Console.ReadLine();
            Console.Write($"Enter amount of times to display {char1}:");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++) 
            { Console.Write(char1); }
            Console.ReadLine();



        }
    }
}
