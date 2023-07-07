using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{
    public class LevenshteinDistance
    {
        public static int Compute(string s, string t)
        {
            //Określenie długości n i m na podstawie długości stringów przekazanych
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];


            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            //Wykreślenie w pionie i poziomie od 0 do x wartości
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            //Dla każdego wolnego miejsca w macierzy wykonaj: 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    //Koszt = 0 jeżeli znaki są takie same, 1 jeżeli znaki są różne
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }
    }

}

