
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum5NumUsingArrayApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] numArray = new double[5];
            double sum = 0;
            Console.WriteLine("this program adds 5 number");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("enter number" + (i + 1).ToString());
                numArray[i] = Convert.ToDouble(Console.ReadLine());
                sum += numArray[i];
                Console.WriteLine("sum upto " + (i+1).ToString() +"th number= " + sum);
            }
            Console.WriteLine("total= "+ sum);
            Console.ReadLine();
        }
    }
}
