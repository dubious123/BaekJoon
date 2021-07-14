using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _5622
    {
        public _5622()
        {

            string input = Console.ReadLine();
            int Ans = 0;
            foreach(char c in input) { Ans += NecessaryTime(c); }
            int NecessaryTime(char c)
            {
                if ('P'<=c && c<='S') { return 8; }
                else if ('T'<=c&&c<='V') { return 9; }
                else if ('W' <= c) { return 10; }
                return ((int)c - (int)'A') / 3 + 3;
            }

            Console.Write(Ans);

        }
    }
}
