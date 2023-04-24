Console.WriteLine("Enter Number1");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Number2");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Number3");
int num3 = int.Parse(Console.ReadLine());

if(num1>num2 && num2 > num3)
{
    Console.WriteLine("Number1 is Largest");
}
else if(num2>num1 && num2 > num3)
{
    Console.WriteLine("Number2 is Largest");
}
else
{
    Console.WriteLine("Number3 is Largest");
}