using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._4
{
    class _1110
    {
        public _1110()
        {
            int count = 0;
            int N = int.Parse(Console.ReadLine());
            int a, b; 
            int newN = N;
            do
            {
                a = newN % 10;
                b = (newN / 10 + newN % 10) % 10;
                newN = a * 10 + b;
                count++;
            }
            while (N!=newN);
            Console.WriteLine(count);
        }

    }
}
