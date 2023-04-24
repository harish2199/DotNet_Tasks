int C = 0;
Console.WriteLine("Sl.No \t Temperature(in celsius) \t Temperature(in Fahrenheit)");
for (int i = 1; i <= 10; i++)
{
    double F = (C * 9 / 5) + 32;
    Console.Write(i+"\t"+C+"\t\t\t\t" + F);
    Console.WriteLine();
    C = C + 10;
}