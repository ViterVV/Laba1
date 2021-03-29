using System;

namespace Exercise_3
{
    class Program
    {
        public delegate int DelegateArray(int x);
        static Random random = new Random();        
        static void Main(string[] args)
        {

            DelegateArray[] delArray = new DelegateArray[]
            {
                delegate(int x) 
                {
                    x = random.Next(1, 99);
                    return x;
                },
                (x) => 
                {
                    x = random.Next(1, 99);
                    return x;
                },
                (x) => 
                {
                    x = random.Next(1, 99);
                    return x;
                }
            };

            int sum = 0;
            for (int i = 0; i < delArray.Length; i++)
            {
                sum += delArray[i](Convert.ToInt32(i));                
            }
            Console.WriteLine("Проверочное число = " + sum);
            sum = sum / delArray.Length;

            Console.WriteLine(sum);
        }
    }
}
