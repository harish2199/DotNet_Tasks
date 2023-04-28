namespace Polymorphism_Demo
{
    internal class Program
    {
        class Demo
        {
            //Method OverLoading
            public virtual void add(int x, int y) 
            {
                Console.WriteLine(x + y);    
            }

            public  void add(int a, int b,int c) //Number of arguments are different
            {
                Console.WriteLine(a + b + c);
            }
            
            public void add(string a, string b,string c) //Type of arguments are different
            {  
                Console.WriteLine(a + b + c);
            }
            public void add(int a, string c) 
            {
                Console.WriteLine(a + c);
            }
            public void add(string a, int c) //Sequence of argument is different
            {
                Console.WriteLine(a + c);
            }
        }

        class Demo1 : Demo
        {
            //Method Overriding
            public override void add(int x, int y)
            {
                Console.WriteLine(x + y);
            }
        }
        public abstract class class1
        {
            public abstract void show();
        }

        class class2 : class1
        {
           
            public override void show()
            {
                Console.WriteLine("Welcome");
            }

        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.add(1, 2);
            demo.add(3, 4, 5);
            demo.add("1","2","3");
            demo.add(1,"3");
            demo.add("1", 8);
        }
    }
}