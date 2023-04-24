char response = 'y';

while (response == 'y')
{
    Console.WriteLine("Enter the temperature in Degree Celsius");
    double C = double.Parse(Console.ReadLine());
    double F = (C * 9 / 5) + 32;
    Console.WriteLine("Temperature in Fahrenheit is " + F);

    Console.WriteLine($"Do you wish to Continue?(y/n)");
    response = Char.Parse(Console.ReadLine());
    response = Char.ToLower(response);

}