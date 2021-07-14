using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _2292
    {
        public _2292()
        {
            int N = int.Parse(Console.ReadLine());
            //R =  N/6+1 : 껍질 개수
            //L =  R-2 꼭짓점 사이 거리  
            //n번째 꼭지점 좌표: 1+6*(R-1)-L(n-6)
            //Ans : 껍질개수 - 1 + abs(가장 가까운 꼭지점 좌표 - N)
        }
    }
}
