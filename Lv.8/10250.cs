using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _10250
    {
        public _10250()
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder Ans = new();
            for(int i = 0; i<T; i++)
            {
               
                string[] input = Console.ReadLine().Split();
                double H = double.Parse(input[0]);
                double W = double.Parse(input[1]);
                double N = double.Parse(input[2]);
                //H : 층수
                //W : 방수 
                double h = N % H;
                double w = N / H;
                if (w - (int)w > 0)
                {
                    w++;
                    //w : 일반적인 상황
                    if (w < 10)
                    {
                        Ans.Append($"{h}0{(int)w}" + "\n");
                        continue;
                    }
                    Ans.Append($"{h}{(int)w}" + "\n");
                    continue;

                }
                //w의 소숫점 부분이 0
                //N은 맨 위층
                if (w < 10)
                {
                    Ans.Append($"{H}0{(int)w}" + "\n");
                    continue;
                }
                Ans.Append($"{H}{(int)w}" + "\n");
                continue;
            }
            Console.Write(Ans);
        }
    }
}
