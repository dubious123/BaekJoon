using System;
using System.Collections.Generic;
using System.Text;

namespace Lv._1
{
    public class _1008
    {
        public _1008()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(decimal.Parse(input[0]) / decimal.Parse(input[1]));
        }
    }
}
