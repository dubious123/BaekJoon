using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _1712
    {
        public _1712()
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            //A = 고정비용
            //B = 가변비용
            //C = 노트북 비용
            //D = 노트북 판매량
            //C * D = A + B * D
            //(C-B)*D = A
            //D = A/(C-B);
            if (C - B <= 0)
            {
                Console.WriteLine(-1);
                return;
            }
            int D = A / (C - B);

            if (D < 0)
            {
                Console.WriteLine(-1);

            }
            else
            {
                Console.WriteLine(D+1);
            }

        }
    }
}
