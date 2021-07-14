using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _11720
    {
        public _11720()
        {
            int N = int.Parse(Console.ReadLine());
            int Sum = 0;
            string input = Console.ReadLine();
            foreach(char c in input) { Sum += int.Parse(c.ToString()); }
            Console.WriteLine(Sum);
        }

    }
}
