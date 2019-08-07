using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number\tsquare\tcube");
            Console.WriteLine("-----\t-------\t-----");
            for(int i = 0; i < 10; i++)
            { Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }
        }
    }
}
