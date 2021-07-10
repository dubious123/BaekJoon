using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2
{
    public class _2753
    {
        public _2753()
        {
            int input = int.Parse(Console.ReadLine());
            if ((input % 4 == 0 && input % 100 != 0) || input % 400 == 0) { Console.WriteLine(1); }
            else { Console.WriteLine(0); }
        }
    }
}
