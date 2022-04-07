using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 =
            {
                {1,2,3 },
                {4,5,6 }
            };
            int[] a = DoubleArrayHelper.GetElements(array1, 1, 2, Direction.Up, 1);
            Console.WriteLine(a[0]);
        }
    }
}
 