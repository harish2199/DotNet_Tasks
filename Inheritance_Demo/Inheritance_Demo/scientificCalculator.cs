using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class scientificCalculator : calculator // inheritance 
    {
        public int x = 20;
        public scientificCalculator() : base(10)
        {
            Console.WriteLine("This is scientificCalculator class constructor");
        }
        public int square(int x)
        {
            return x * x;
        }
        public int cube(int x) {
            return x * x * x;
        }
        public int factorial(int x)
        {
            int fact = 1;
            for(int i = 1; i < x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public new void show() 
        {
            Console.WriteLine("This is show method in ScientificCalculator class");
        }

        public void display()
        {
            Console.WriteLine("Value of x = "+ base.x); // By using base keyword it refers to the base class
            Console.WriteLine("Value of x = " + this.x);// By using this keyword it refers to the current class
        }
    }
}
