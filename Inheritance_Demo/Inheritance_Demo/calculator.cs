using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class calculator
    {
        public int x = 10;
        public calculator() {
            Console.WriteLine("This is calculator class constructor");
        }
        public calculator(int x)
        {
            Console.WriteLine("Value of x = "+ x);
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtract(int x, int y)
        {
            return x - y;
        }
        public int multiply(int x, int y)
        {
            return x * y;
        }

        public double divide(double x, double y)
        {
            return x / y;
        }

        public void show()
        {
            Console.WriteLine("This is show method in calculator class");
        }
    }
}
