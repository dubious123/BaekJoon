using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _3052
    {
        public _3052()
        {
            List<int> list = new();
            int item;
            for(int i = 0; i<10; i++)
            {
                item = int.Parse(Console.ReadLine()) % 42;
                if(list.Contains(item)) { continue; }
                list.Add(item);
            }
            Console.WriteLine(list.Count);
        }
    }
}
