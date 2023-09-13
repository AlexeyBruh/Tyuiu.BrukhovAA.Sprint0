using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BrukhovAA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            //В реальных проектов используется Exception
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя");
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}

