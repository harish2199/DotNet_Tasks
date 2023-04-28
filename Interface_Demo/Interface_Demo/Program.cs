namespace Interface_Demo
{

    interface MyInterface1
    {
        void sum(int x, int y);

        void subtract(int x, int y);
    }

    interface MyInterface2 {
        void square(int x);

        void cube(int x);
    }
    interface MyInterfce3 : MyInterface1, MyInterface2
    {
        void multiply(int x, int y);

        void divide(int x, int y);
    }

    class class1
    {
        public virtual void show()
        {
            Console.WriteLine("This is show methid in class1");
        }
    }

    class class2 : class1, MyInterfce3 //(or) : class1,MyInterface1,MyInterface2,MyInterface3
    {
        public override void show()
        {
            Console.WriteLine("This is show method in class2");
        }

        public void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public void square(int x)
        {
            Console.WriteLine(x * x);
        }
        public void cube(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 obj = new class2();
            obj.show();
            obj.sum(2, 3);
            obj.subtract(2, 3);
            obj.divide(2, 3);
            obj.multiply(2, 3);
            obj.square(3);
            obj.cube(3);
        }
    }
}