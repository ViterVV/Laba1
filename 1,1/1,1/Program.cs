using System;

namespace Exercise_1
{
    public delegate int MyDelegate(int x,int y,int z);
    class Program
    {

        static void Main(string[] args)
        {
            MyDelegate del;
            del = delegate (int x, int y, int z) { return (x + y + z) / 3; };
            int avg = del(5, 4, 3);
            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
