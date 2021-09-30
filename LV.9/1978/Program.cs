using System;

namespace Lv._9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int Ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (IsPrime(int.Parse(input[i])))
                {
                    Ans++;
                }
            }
            Console.WriteLine(Ans);
        }
        protected static bool IsPrime(int x)
        {
            if (x == 1)
            {
                return false;
            }
            if (x == 2)
            {
                return true;
            }
            if (x % 2 == 0)
            {
                return false;
            }
            for (int j = 3; j <= Math.Sqrt(x); j++)
            {
                if (x % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
