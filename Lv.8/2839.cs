using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _2839
    {
        public _2839()
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 4 || N == 7)
            {
                Console.WriteLine(-1);
                return;
            }
            if (N == 3)
            {
                Console.WriteLine(1);
                return;
            }
            int[] pattern = new int[5] { 1, 2, 3, 2, 3 };

            Console.WriteLine(pattern[N % 5] + N / 5 - 1) ;
        }

    }
}
