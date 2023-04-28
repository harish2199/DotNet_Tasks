using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public class calculator
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int  mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
}