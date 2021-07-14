using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _2675
    {
        public _2675()
        {
            StringBuilder Ans = new();
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int inputN = int.Parse(input[0]);
                string inputString = input[1];
                for(int t = 0; t < inputString.Length; t++)
                {
                    for(int j = 0; j < inputN; j++) { Ans.Append(inputString[t]); }
                }
                if (i < N-1) { Ans.Append("\n"); }
                



            }
            Console.Write(Ans);

        }
    }
}
