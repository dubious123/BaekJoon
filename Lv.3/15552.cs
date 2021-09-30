using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _15552
    {
        public _15552()
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder result = new();
            string[] input;
            for (int i = 0; i < T; i++)
            {
                input = Console.ReadLine().Split();
                result.Append(int.Parse(input[0]) + int.Parse(input[1]) + "\n");
            }
            Console.WriteLine(result);
        }
    }
}
