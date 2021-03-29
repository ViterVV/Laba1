using System;

namespace Exercise_2
{
    public delegate int Operation(int x, int y);
    class Program
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Sub(int x, int y)
        {
            return x - y;
        }
        private static int Mul(int x, int y)
        {
            return x * y;
        }
        private static int Div(int x, int y)
        {

            if (x == 0 || y == 0)
            {
                try
                {
                    return x / y;
                }
                catch
                {
                    Console.WriteLine("Cannot be divided by zero");
                }
            }
            else 
            {
                return x / y;
            }

            return default;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            var numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var numY = Convert.ToInt32(Console.ReadLine());


            Operation op = Add;
            var result = op(numX, numY);
            op += (x, y) => x + y;
            Console.WriteLine($"\n{result}");

            op = Sub;
            result = op(numX, numY);
            op += (x, y) => x - y;
            Console.WriteLine(result);

            op = Mul;
            result = op(numX, numY);
            op += (x, y) => x * y;
            Console.WriteLine(result);

            op = Div;
            result = op(numX, numY);
            op += (x, y) => x / y;
            Console.WriteLine(result);

        }
    }
}
