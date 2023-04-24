Console.WriteLine("Enter the length of the rectangle");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the breadth of the rectangle");
double breadth = Convert.ToDouble(Console.ReadLine());

double perimeter;

perimeter = 2 * (length + breadth);

Console.WriteLine("Perimeter of a rectangle is "+perimeter);