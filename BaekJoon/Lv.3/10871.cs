using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _10871
    {
        public _10871()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);
            StringBuilder result = new();
            string[] sequence = Console.ReadLine().Split();
            for(int i = 0; i < sequence.Length; i++)
            {
                if (int.Parse(sequence[i]) < X) { result.Append($"{sequence[i]} "); }
            }
            Console.Write(result);
        }
    }
}
