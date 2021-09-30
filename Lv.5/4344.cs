using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._5
{
    class _4344
    {
        public _4344()
        {
            int C = int.Parse(Console.ReadLine());
            int N, numberOfStudent;
            double avg;
            List<int> score = new();
            StringBuilder result = new();
            string[] input;
            for (int i = 0; i < C; i++)
            {
                input = Console.ReadLine().Split();
                numberOfStudent = 0;
                N = int.Parse(input[0]);
                for (int j = 1; j <= N; j++) { score.Add(int.Parse(input[j])); }
                avg = score.Average();
                foreach (int a in score) { if (a > avg) { numberOfStudent++; } }

                result.Append(string.Format("{0:0.000}", (double)numberOfStudent / (double)N * 100)+"%"+"\n");
                score.Clear();
            }
            Console.Write(result);
        }
    }
}
