﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 76;
            int finish = 46;
            Console.WriteLine("Display the odd numbers from 76 to 46");
            while (start>=finish)
            { if(start % 2 != 0)
                    Console.WriteLine(start); start--;

            }


        }
    }
}
