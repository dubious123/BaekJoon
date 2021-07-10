using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._4
{
    class _10951
    {
        public _10951()
        {
            StringBuilder result = new();
            while (true)
            {
                string input1 = Console.ReadLine();
                if (input1 == null) { break; }
                string[] input2 = input1.Split();
                result.Append(int.Parse(input2[0]) + int.Parse(input2[1]) + "\n");
            }
            Console.Write(result);
        }
    }
}
