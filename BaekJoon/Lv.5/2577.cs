using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _2577
    {
        public _2577()
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()));
            int[] result = new int[10];
            StringBuilder result2 = new();
            foreach(char c in input) {result[int.Parse(Convert.ToString(c))]++;}
            foreach (int n in result) { result2.Append(n + "\n"); }
            Console.WriteLine(result2);
        }
    }
}
