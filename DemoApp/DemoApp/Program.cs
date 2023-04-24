namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int num1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2=Convert.ToInt32(Console.ReadLine());

            int num3=num1 + num2;

            Console.WriteLine("Sum = "+num3);


        }
    }
}