﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BrukhovAA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.BrukhovAA.Sprint0.Task2.V0.lib
            Console.WriteLine(DataService.GetMessage("Алексей"));
            Console.ReadKey();
        }
    }
}
