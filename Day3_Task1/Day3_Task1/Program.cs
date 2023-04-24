Console.WriteLine("Enter a Five digit Number");
int num=int.Parse(Console.ReadLine());
int sum = 0;
int res;

while (num > 0)
{
    res = num % 10;
    sum += res;
    num = num / 10;
}
Console.WriteLine($"Sum of individual digits is {sum}");