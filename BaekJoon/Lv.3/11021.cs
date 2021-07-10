using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _11021
    {
        public _11021()
        {
            int T = int.Parse(Console.ReadLine());
            int temp;
            StringBuilder result = new();
            string[] input;
            for (int i = 1; i <= T; i++)
            {
                input = Console.ReadLine().Split();
                temp = int.Parse(input[0]) + int.Parse(input[1]);
                result.Append($"Case #{i}: "+temp + "\n");
            }
            Console.WriteLine(result);
        }
    }
}
