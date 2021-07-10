using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._4
{
    public class _10952
    {
        public _10952()
        {
            StringBuilder result = new();
            while(true) 
            { 
                
                string[] input = Console.ReadLine().Split();
                if(input[0] == "0" && input[1] == "0") { break; }
                else { result.Append(int.Parse(input[0]) + int.Parse(input[1]) + "\n"); }
            }
            Console.Write(result);
        }
    }
}
