using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _8958
    {
        public _8958()
        {
            StringBuilder result = new();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int n = 0;
                int score = 0;
                foreach(char OX in Console.ReadLine()) 
                {

                    if (OX == 'O') { n++; }
                    else
                    {
                        if (n == 0) { continue; }
                        score += n * (n + 1) / 2;
                        n = 0;
                    }
                }
                score += n * (n + 1) / 2;
                result.Append(score + "\n");
            }
            Console.WriteLine(result);
        }
    }
}
