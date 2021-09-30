using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _2869
    {
        public _2869()
        {
            string[] input = Console.ReadLine().Split();
            double A = int.Parse(input[0]);
            double B = int.Parse(input[1]);
            double V = int.Parse(input[2]);
            var Day = (V - B) / (A - B);
            if (Day - (int)Day > 0)
            {
                Console.WriteLine((int)Day + 1);
                return;
            }
            Console.WriteLine(Day);
        }
    }
}
