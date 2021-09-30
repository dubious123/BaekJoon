using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._7
{
    class _2941
    {
        public _2941()
        {
            string input = Console.ReadLine();
            int Ans = input.Length;
            for(int i = 1; i<input.Length;i++)
            {
                char c = input[i];
                char prec = input[i - 1];
                switch (c)
                {
                    case '=':
                        if (prec == 'z'||prec == 's'||prec=='c')
                        {
                            if (prec == 'z' && i>=2 && input[i - 2]=='d') { Ans--; }
                            Ans --;
                            continue;
                        }
                        break;
                    case '-':
                        if (prec == 'c' || prec == 'd')
                        {
                            Ans --;
                            continue;
                        }
                        break;
                    case 'j':
                        if (prec == 'l' || prec == 'n')
                        {
                            Ans --;
                            continue;
                        }
                        break;
                    default:
                        break;

                }
            }
            Console.Write(Ans);
        }
    }
}
