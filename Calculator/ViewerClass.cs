using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ViewerClass
    {
        public void ViewerName(string name)
        {
            Console.WriteLine("Hello viewer " + name);
        }
        public void printTable(int a)
        {
            int index = 10;
            while (index != 0)
            {
                Console.WriteLine(a + " * " + index + " = " + a * index);
                index--;
            }
        }
    }
}
