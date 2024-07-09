using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MethodsClass
    { public int add(int a, int b)
        {
            return a + b;
        }
        public int susbtract(int a, int b) {  return a - b; }
        public int multiply(int a,int b) { return a * b; }
        public int divide (int a,int b) {return a / b; }
        public int remainder(int a,int b) { return (a % b); }
    }
}
