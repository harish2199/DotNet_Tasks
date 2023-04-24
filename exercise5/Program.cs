Console.WriteLine("Enter the distance in Kilometers");
double distance=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the speed in Kilometers per hour");
double speed=Convert.ToDouble(Console.ReadLine());

double time=distance/speed;

Console.WriteLine("Time Taken For Journey ="+time);