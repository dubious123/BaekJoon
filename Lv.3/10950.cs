using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._3
{
    public class _10950
    {
        public _10950()
        {
            int T = int.Parse(Console.ReadLine());
            for(int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(input[0])+ int.Parse(input[1]));
            }
        }
    }
}
