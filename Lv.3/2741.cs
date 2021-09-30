using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _2741
    {
        public _2741()
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder result = new();
            for(int i = 1; i <= N; i++) { result.Append(i + "\n"); }
            Console.WriteLine(result);
        }
    }
}
