using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _1157
    {
        public _1157()
        {
            int Max = 0; ;
            char? Ans = null;
            string input = Console.ReadLine().ToUpper();
            Dictionary<char, int> mydict = new();
            foreach(char c in input)
            {
                if (mydict.ContainsKey(c)) { mydict[c]++; }
                else { mydict.Add(c,1); }
            }
            foreach(KeyValuePair<char,int> pair in mydict)
            {
                if (pair.Value > Max) { Ans = pair.Key; Max = pair.Value; }
                else if(pair.Value == Max) { Ans = '?'; }
            }
            Console.WriteLine(Ans);
        }
    }
}
