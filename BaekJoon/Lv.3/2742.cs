using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _2742
    {
        public _2742()
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder result = new();
            for (int i = N; i >0; i--) { result.Append(i + "\n"); }
            Console.WriteLine(result);
        }
    }
}
