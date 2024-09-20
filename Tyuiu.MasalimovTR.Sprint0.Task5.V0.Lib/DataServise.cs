using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MasalimovTR.Sprint0.Task5.V0.Lib
{
    public class DataServise
    {
        public static int Addition(int a, int b)
        { return a + b; }
        public static int Subtraction(int a, int b)
        { return a - b; }
        public static int Multiolication(int a, int b)
        { return a * b; }
        public static Double Division(int a, int b)
        {
            if (b == 0)
            { return -1; }
            else
            { return a / b; }
        }
    }
}
