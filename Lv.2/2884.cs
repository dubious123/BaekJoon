using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2
{
    public class _2884
    {
        public _2884()
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            if(M < 45)
            {
                if (H == 0) { Console.WriteLine($"23 {15+M}"); }
                else { Console.WriteLine($"{H-1} {15+M}"); }
            }
            else
            {
                Console.WriteLine($"{H} {M-45}");
            }
        }
    }
}
