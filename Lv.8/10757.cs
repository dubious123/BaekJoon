using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{

    class _10757
    {


        public List<int> Add(string[] input)
        {

            int i;
            int plusValue;
            int overflow = 0;
            string A = input[0];
            string B = input[1];
            if (A.Length >= B.Length)
            {
                string temp;
                temp = A;
                A = B;
                B = temp;
            }
            //B >= A (다른 자릿수일 때)
            int A_Length = A.Length;
            int B_Length = B.Length;
            List<int> Ans = new List<int>();
            for (i = 0; i< A_Length; i++)
            {
                plusValue = A[A_Length-i-1] + B[B_Length-i-1] - '0' * 2+ overflow;
                if(plusValue > 9)
                {
                    overflow = 1;
                    plusValue -= 10;
                }
                else
                {
                    overflow = 0;
                }
                Ans.Add(plusValue);
            }
            for (; i < B_Length; i++)
            {
                plusValue = B[B_Length - i - 1] - '0' + overflow;
                if (plusValue > 9)
                {
                    overflow = 1;
                    plusValue -= 10;
                }
                else
                {
                    overflow = 0;
                }
                Ans.Add(plusValue);
            }
            if (overflow == 1)
            {
                Ans.Add(1);
            }
            Ans.Reverse();
            return Ans;
        }
        public _10757()
        {
            string[] input = Console.ReadLine().Split();    
            Console.WriteLine(string.Join("", Add(input)));
        }
    }
}
