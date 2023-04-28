using ClassLibrary1;
using System.Net.Http.Headers;
using System.Transactions;

namespace Demo_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator calculator = new calculator();
            
            Console.WriteLine("enter your choice:(1-ADD,2-SUB,3-MUL,4-DIV)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Number 2:");
            int num2 = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Output= "+calculator.sum(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Output= " + calculator.sub(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Output= " + calculator.mul(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Output= " + calculator.div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}