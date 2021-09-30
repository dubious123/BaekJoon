using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _10818
    {
        public _10818()
        {
            int N = int.Parse(Console.ReadLine());
            int Max = -1000000, Min = 1000000, temp;
            string[] array = Console.ReadLine().Split();
            foreach(string item in array)
            {
                temp = int.Parse(item);
                if (Max < temp) { Max = temp; }
                if (Min > temp) { Min = temp; }
            }
            Console.WriteLine($"{Min} {Max}");
        }
    }
}
