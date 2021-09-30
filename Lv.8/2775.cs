using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._8
{
    class _2775
    {
        public _2775()
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder Ans = new();
            int[] K = new int[T];
            int[] N = new int[T];
            for(int i = 0; i < T; i++)
            {
                K[i] = int.Parse(Console.ReadLine());
                N[i] = int.Parse(Console.ReadLine());   
            }
            int KMax = K.Max();
            int NMax = N.Max();
            int[,] Apartment = new int[KMax+1,NMax];
            for(int i = 0; i < NMax; i++)
            {
                Apartment[0, i] = i + 1; //0층 채우기
            }
            for(int k = 1; k <= KMax; k++) //1층부터 시작
            {
                for(int n = 0; n < NMax; n++) //1호부터 시작
                {
                    if (n == 0)
                    {
                        //1호
                        Apartment[k, n] = Apartment[k - 1, n];
                        continue;
                    }
                    Apartment[k, n] = Apartment[k, n - 1] + Apartment[k - 1, n];
                }
            }
            //아파트 생성 완료
            for (int i = 0; i < T; i++)
            {
                Ans.Append($"{Apartment[K[i], N[i]-1]}" + "\n");
            }
            Console.Write(Ans);
        }
    }
}
