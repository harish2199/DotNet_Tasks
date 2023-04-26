namespace OOPS_DEMO
{
    class calculator
    {
        public void show()
        {
            Console.WriteLine("This is show method");
        }

        public void hello(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }

        public int add(int x,int y)
        {
            return x+y;
        }

        public void sum(int x,int y, int z = 18) // assigning default values, it should be right to left
        {
            Console.WriteLine(x+y+z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator cal = new calculator();
            cal.show();

            cal.hello("Harish");

            Console.WriteLine(cal.add(1,2));
            //(or)
            int res = cal.add(1,2);
            Console.WriteLine(res);

            cal.sum(1,2);
        }
    }
}