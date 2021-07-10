using System;
using System.Collections.Generic;
using System.Text;

namespace Lv._1
{
    public class _2588
    {
        public _2588()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a*(b%10));
            Console.WriteLine(a*((b/10)%10));
            Console.WriteLine(a * (b/100));
            Console.WriteLine(b*a);
        }
    }
}
