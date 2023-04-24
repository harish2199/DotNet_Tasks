Console.WriteLine("Enter first Number");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second Number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a Sign");
Char Sign = Char.Parse(Console.ReadLine());

switch (Sign)
{
    case '+':
        {
            Console.WriteLine("Sum of two Numbers is "+ (num1 + num2) );
            break; 
        }
    case '-':
        {
            Console.WriteLine("Subraction of two Numbers is " + (num1 - num2));
            break;
        }
    case '*':
        {
            Console.WriteLine("Product of two Numbers is " + (num1 * num2));
            break;

        }
    case '/':
        {
            Console.WriteLine("Division of two Numbers is " + (num1 / num2));
            break;
        }
    default:
        {
            Console.WriteLine("Invalid Sign");
            break;
        }
}