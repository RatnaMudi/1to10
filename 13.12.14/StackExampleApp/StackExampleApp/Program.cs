using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack = new Stack<int>();
            aStack.Push(100);
            aStack.Push(200);
            aStack.Push(150);
            foreach (int anItem in aStack)
            {
                Console.WriteLine(anItem);
                //stack pops in reverse way
            }
            Console.ReadKey();

        }
    }
}
