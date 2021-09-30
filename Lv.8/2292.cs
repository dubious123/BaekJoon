using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _2292
    {
        public _2292()
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.WriteLine("1");
                return;
            }
            //R = 껍질 개수
            int R = 1;
            int minIndex;
            int maxIndex;
            while (true)
            {
                R++;
                minIndex = 3 * (int)Math.Pow(R, 2) - 9 * R + 8;
                maxIndex = 3 * (int)Math.Pow(R, 2) - 3 * R + 1;
                if (minIndex <= N && N <= maxIndex)
                {
                    Console.Write(R);
                    break;
                }
            }
        }
    }
}
