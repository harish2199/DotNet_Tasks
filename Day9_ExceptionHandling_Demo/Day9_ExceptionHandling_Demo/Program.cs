using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Day9_ExceptionHandling_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3 = 0; 
           
            try
            {
                Console.WriteLine("Enter First Number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                num2 = int.Parse(Console.ReadLine());
                num3 = num1 / num2; // ex: 2/0 gives DivideByzeroException
                if (num1 < num2)
                {
                    //throw new InvalidValueException("num2 should not be greater than num1");
                    throw new InvalidValueException();
                }
            }
            
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            catch (DivideByZeroException)
            {
                Console.WriteLine("you cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("you can only give numbers");
            }
            catch (InvalidValueException)
            {
                Console.WriteLine("num2 should not be greater than num1");
            }
            //catch (InvalidValueException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (Exception)  // if any other exception can occur
            {
                Console.WriteLine("Something Went wrong");
            }
            
            finally
            {
                Console.WriteLine("Result = " + num3);
                Console.WriteLine("Program ends.");
            }
        }
    }
}