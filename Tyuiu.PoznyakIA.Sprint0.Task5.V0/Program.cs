﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PoznyakIA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PoznyakIA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B =" + DataService.Addition(1, 5));
            Console.WriteLine("A - B =" + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B =" + DataService.Multiplication(10, 5));
            Console.WriteLine("A / B =" + DataService.Division(6, 0));
            Console.ReadLine();
        }
    }
}
