using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10] {4, 1, 8, 2, 4, 0, 3, 9, 14, -2};
            Array.Sort(numArray);
            foreach (int i in numArray)
            {
                Console.WriteLine(i);
            }
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    Console.WriteLine(numArray[i]);
            //}
            Console.ReadLine();
        }
    }
}
