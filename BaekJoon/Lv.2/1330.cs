using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2
{
    public class _1330
    {
        public _1330()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            if (a > b)
            {
                Console.WriteLine('>');
            }
            else if (a == b)
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine('<');
            }

        }
    }
}
