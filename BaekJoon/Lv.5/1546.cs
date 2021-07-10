using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _1546
    {
        public _1546()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> input = new();
            foreach(string s in Console.ReadLine().Split()) { input.Add(int.Parse(s)); }
            Console.WriteLine(input.Average()/input.Max()*100);


        }
    }
}
