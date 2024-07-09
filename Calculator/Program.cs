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
            int add = mc.add(10, 20);
            Console.WriteLine("Addition is "+add);
            ViewerClass viewerClass = new ViewerClass();
            viewerClass.printTable(10);
            timepass tp = new timepass();
            Console.ReadLine();

        }
    }
}
