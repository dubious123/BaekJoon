using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _1316
    {
        public _1316()
        {
            int N = int.Parse(Console.ReadLine());
            int Ans = 0;
            for(int i = 0; i < N; i++)
            {
                bool[] visited = new bool[26];

                string inputString = Console.ReadLine();
                bool isGroupWord = true;
                for(int j = 0;j<inputString.Length;j++)
                {
                    char nowChar = inputString[j];
                    //방문한 적이 없다.
                    if (!visited[nowChar - 'a'])
                    {
                        visited[nowChar - 'a'] = true;
                        continue;
                    }
                    //이전에 방문한 적이 있다.
                    //적어도 인덱스가 1 이상이다
                    //1. 이전 문자열과 다르다 -> 그룹단어가 아니다
                    if (inputString[j - 1] != nowChar)
                    {
                        isGroupWord = false;
                        break;
                    }
                    //2. 이전 문자열과 같다 -> 다음으로 이동
                }
                if (isGroupWord)
                {
                    Ans++;
                }
            }
            Console.Write(Ans);
        }
    }
}
