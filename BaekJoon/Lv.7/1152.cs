using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _1152
    {
        public _1152()
        {
            string inputString = Console.ReadLine();
            string[] input = inputString.Split();
            int Ans = input.Length;
            if (inputString[0]==' ')
            {
                Ans--;
            }
            if(inputString[inputString.Length-1]==' ')
            {
                Ans--;
            }
            if (Ans < 0)
            {
                Ans = 0;
            }
            Console.WriteLine(Ans);
        }
    }
}
