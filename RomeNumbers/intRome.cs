using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomeNumbers
{
    public class Rome
    {

        private static int[] arabic = { 1000,100,10,1};
        private static char[] roman = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
        private static int ROMAN_N = arabic.Length;

        static public string toRome(int a)
        {
            StringBuilder s = new StringBuilder();

            if (a < 0 || a>3999)
                throw new ArgumentOutOfRangeException();

            int ii = 0;

            for (int i = 0; i < 4; i++, ii+=2)
            {
                int tmp = a / arabic[i];

                if (1 <= tmp && tmp <= 3)
                    for (int j = 1; j <= tmp; j++)
                        s.Append(roman[ii]);
                else if (tmp == 4)
                    s.Append(roman[ii]).Append(roman[ii - 1]);
                else if (tmp == 5)
                    s.Append(roman[ii - 1]);
                else if (6 <= tmp && tmp <= 8)
                {
                    s.Append(roman[ii - 1]);
                    for (int j = 1; j <= tmp - 5; j++)
                        s.Append(roman[ii]);
                }
                else if (tmp == 9)
                    s.Append(roman[ii]).Append(roman[ii - 2]);
                else
                    s.Append("");

                a %= arabic[i];
            }


            return s.ToString();
        }

    }
}
