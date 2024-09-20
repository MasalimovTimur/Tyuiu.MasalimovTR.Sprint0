using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MasalimovTR.Sprint0.Task6.V0.Lib
{
    public class DataServise
    { public static object AdditionArray(int[] nubmers)
        {
            var total = 0;
            for (var i = 0; i < nubmers.Length; i++)
            { total = total + nubmers[i]; }
            return total;
        }
        public static object SubtractionArray(int[] nubmers) {
            var total = 0;
            var index = 0;
            while (index < nubmers.Length)
            {
                total = total - nubmers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] nubmers) {
            var total = 1;
            int index = 0;
            do { total = total * nubmers[index]; index++; }
            while (index < nubmers.Length);
            return total;

        }





    }
    
}
