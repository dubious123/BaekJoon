using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _2439
    {
        public _2439()
        {
            int input = int.Parse(Console.ReadLine());
            int i, j;
            StringBuilder result = new();
            for (i = 0; i < input; i++)
            {
                for(j = input-i-2; j >= 0; j --) { result.Append(" "); }
                while (i - j > 0)
                {
                    result.Append("*");
                    j++;
                }
                if (i != input - 1) { result.Append("\n"); }
            }
          
            Console.Write(result);
        }
    }
}
