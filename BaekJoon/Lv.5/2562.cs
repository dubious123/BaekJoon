using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _2562
    {
        public _2562()
        {
            List<int> list = new();
            for(int i = 0; i < 9; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(list.Max());
            Console.WriteLine(list.IndexOf(list.Max())+1);
        }
    }
}
