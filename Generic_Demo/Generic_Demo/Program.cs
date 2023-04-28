namespace Generic_Demo
{
    class Demo<T>
    {
        T value;
        public void read(T value)
        {
            this.value = value;
        }

        public T write()
        {
            return value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int> demo1 = new Demo<int>();
            demo1.read(1);
            Console.WriteLine(demo1.write());

            Demo<string> demo2 = new Demo<string>();
            demo2.read("Harish");
            Console.WriteLine(demo2.write());
        }
    }
}