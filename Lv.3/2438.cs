using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _2438
    {
        public _2438()
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder result = new();
            for( int i=0; i<input; i++) 
            { 
                for(int j = 0; j <= i; j++) { result.Append("*"); }
                result.Append("\n");
            }
            Console.WriteLine(result);
        }

    }
}
