using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _2908
    {
        public _2908()
        {
            string[] input = Console.ReadLine().Split();
            char[] A = input[0].ToCharArray().Reverse().ToArray();
            char[] B = input[1].ToCharArray().Reverse().ToArray();
            if (int.Parse(A) > int.Parse(B)) { Console.WriteLine(A); }
            else { Console.WriteLine(B); }

        }
    }
}
