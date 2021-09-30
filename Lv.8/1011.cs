using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _1011
    {
        public _1011()
        {
            StringBuilder Ans = new();
            int T = int.Parse(Console.ReadLine());
            int x;
            int y;
            int delta;
            int k;
            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split();
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
                delta = y - x;
                k = (int)Math.Sqrt(delta);
                if(delta - k * k == 0)
                {
                    //delta : 제곱수
                    Ans.Append(2 * k - 1 + "\n");
                    continue;
                }
                if(k*(k+1) >= delta)
                {
                    Ans.Append(2 * k + "\n");
                    continue;
                }
                Ans.Append(2 * k + 1 + "\n");
            }
            Console.WriteLine(Ans);
        }
    }
}
