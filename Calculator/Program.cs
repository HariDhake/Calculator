using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodsClass mc=new MethodsClass();
            PirnterClass pirnterClass=new PirnterClass();
            int add = mc.add(10, 20);
            Console.WriteLine("Addition is "+add);
        }
    }
}
