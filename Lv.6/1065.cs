using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._6
{
    class _1065
    {
        public _1065()
        {
            int N = int.Parse(Console.ReadLine());
            int Ans = 9;
            if (N < 10)
            {
                Console.WriteLine(N);
                return;
            }
            for (int i = 10; i <= N; i++)
            {
                if (isHansoo(i)) { Ans++; }
            }
            Console.WriteLine(Ans);
        }
        public bool isHansoo(int num)
        {
            string stringNum = num.ToString();
            int count = 0;
            int[] intNum = new int[stringNum.Length];
            foreach (char n in stringNum)
            {
                intNum[count++] = int.Parse(n.ToString());
            }
            int diff = intNum[0] - intNum[1];
            for (int i = 0; i < intNum.Length - 1; i++)
            {
                if (intNum[i] != intNum[i + 1] + diff) { return false; }
            }
            return true;
        }
    }
}
