﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldVS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello, World!");
            }
            else
            {
                string name = args[0];
                Console.WriteLine ("Hello, " + name);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
