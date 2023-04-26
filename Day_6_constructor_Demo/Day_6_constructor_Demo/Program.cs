namespace Day_6_constructor_Demo
{
    class constructor_demo
    {
        public constructor_demo() {
            Console.WriteLine("This is constructor 1");
        }
        public constructor_demo(int x)
        {
            Console.WriteLine("This is constructor 2");
        }
        public constructor_demo(int x, string s)
        {
            Console.WriteLine("This is constructor 3");
        }

        public void show() {
            Console.WriteLine("This is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            constructor_demo demo = new constructor_demo();
            constructor_demo demo1 = new constructor_demo(2);
            constructor_demo demo2 = new constructor_demo(2,"Hii");
            demo.show();
            demo1.show();
            demo2.show();
        }

    }
}