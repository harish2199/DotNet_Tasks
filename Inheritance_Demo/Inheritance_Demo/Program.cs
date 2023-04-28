namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            scientificCalculator calculator = new scientificCalculator();
            calculator.subtract(1, 2);
            calculator.cube(5);
            Console.WriteLine(calculator.x);//giving derived class x
            Console.WriteLine(calculator.x);//giving derived class x
            calculator.show(); //giving derived class show method
            calculator.display();
        }
    }
}