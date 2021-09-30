using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _1193
    {
        public _1193()
        {
            int N = int.Parse(Console.ReadLine());
            int firstIndex = 0;
            int lastIndex = 0;
            int R = -1;
            int delta;
            
            int child = 0;
            int parent = 0;
            while (true)
            {
                R++;
                firstIndex = lastIndex + 1;
                lastIndex = firstIndex + R;
                if (firstIndex <= N && lastIndex >= N)
                {
                    break;
                }
            }
            delta = N - firstIndex;
            if (R % 2 == 0)
            {
                child = R + 1 - delta;
                parent = 1 + delta;
            }
            else
            {
                parent = R + 1 - delta;
                child = 1 + delta;
            }
            Console.WriteLine($"{child}/{parent}");
        }
    }
}
