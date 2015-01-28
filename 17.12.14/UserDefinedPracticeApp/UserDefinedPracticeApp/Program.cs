using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item aItem= new Item();
            aItem.name = "mouse";
            aItem.price = 500;
            aItem.discount = 40;

            Item bItem= new Item();
            bItem.name = "keyboard";
            bItem.price = 400;
            bItem.discount = 50;
        }
    }
}
