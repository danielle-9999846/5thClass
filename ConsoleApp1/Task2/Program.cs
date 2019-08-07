using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 times table:");
            Console.WriteLine("------------");
            Console.WriteLine(">>>for loop<<<");
            int number = 7;
            for (int i = 1; i <= 12; i++)
            Console.WriteLine($"{i} x {number} = {i* number}");

            Console.WriteLine("\n>>>while loop<<<");
            int counter = 1;
            while (counter <= 12)
            { Console.WriteLine($"{counter} x {number} = {counter*number}"); counter++;
            }
            Console.WriteLine("\n>>>do while loop<<<");
            counter = 1;
            do
            { Console.WriteLine($"{counter} x {number} = {counter * number}"); counter++; }
            while (counter <= 12);


        }

    }
}
