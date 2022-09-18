using System;

namespace p17._1
{
    internal class Program
    {
        static int factorial(int i)
        {
            int res;

            if (i == 1)
            {
                return 1;
            }
            res = factorial(i - 1) * i;
            return res;
        }

        static void Main()
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"res = {factorial(n)}");
        }
    }
}
