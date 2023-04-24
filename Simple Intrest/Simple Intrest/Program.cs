Console.WriteLine("Enter the principle amount");
double principle =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Annual intrest rate");
double rate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Time(In years)");
double time = Convert.ToDouble(Console.ReadLine());


double interest = (principle * time * rate) / 100;


Console.WriteLine("Final Amount= " + interest);