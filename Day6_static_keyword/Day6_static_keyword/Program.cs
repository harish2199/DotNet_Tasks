namespace Day6_static_keyword
{
    class demo
    {
        //without using static keyword
        //int num = 0;

        //using static keyord

         static int num = 0;
        public void increment()
        {
            num++;
            Console.WriteLine(num);
        }

        //static keyword for method 
        public static void show()
        {
            Console.WriteLine("This is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo demo1 = new demo();
            demo demo2 = new demo();
            demo demo3 = new demo();
            demo demo4 = new demo();

            //calling non static methods using instances
            demo1.increment();
            demo2.increment();  
            demo3.increment();  
            demo4.increment();

            //calling static method directly with class name
            demo.show();    

        }
    }
}