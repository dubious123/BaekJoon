using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _10809
    {
        public _10809()
        {
            string input = Console.ReadLine();
            StringBuilder Ans = new();
            
            for(int i = 0; i < 'z' - 'a' + 1; i++)
            {
                char c = Convert.ToChar(i + Convert.ToInt32('a'));
                if(input.Contains(c)) { Ans.Append($"{input.IndexOf(c)} "); }
                else { Ans.Append($"{-1} "); }
            }
            Console.Write(Ans);
            
        }
    }
}
