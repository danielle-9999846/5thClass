using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 3;
            int finish = 7;
            Console.WriteLine(" >>> for loop <<<");

            for (int i = start; i <= finish; i++)
            { Console.WriteLine($"{i}\t{i * 10}\t{i * 100}\t{i * 1000}");

            }

            Console.WriteLine(">>>while loop<<<");
            while(start<=finish)
            { Console.WriteLine($"{start}\t{start*10}\t{start*100}\t{start*1000}"); start++; }

            Console.WriteLine(">>>do while loop<<<");
            start = 3;
            do

            { Console.WriteLine($"{start}\t{start * 10}\t{start * 100}\t{start * 1000}"); start++; }
            while (start <= finish);

          



        

            

            
        }
    }
}
