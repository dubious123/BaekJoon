using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._6
{
    class _4673
    {
        Dictionary<int, bool> SelfNum = new();
        StringBuilder Ans = new();
        public int _maxValue { get; private set; }

        public void d(int n)
        {
            if (n > _maxValue) { return; }
            string input = n.ToString();
            int result = n;
            foreach(char num in input)
            {
                result += int.Parse(num.ToString());
            }
            if(result <= _maxValue) { SelfNum.Remove(result); }
            d(result);
            return ; 
        }
        public _4673(int n)
        {
            _maxValue = n;
            for(int i = 1; i <= _maxValue; i++)
            {
                SelfNum.Add(i, true);
            }
            for(int i = 1; i <= n; i++)
            {
                d(i);
                if (SelfNum.ContainsKey(i)) { Ans.Append(i + "\n"); }
            }
            Console.Write(Ans);
        }
    }
}
