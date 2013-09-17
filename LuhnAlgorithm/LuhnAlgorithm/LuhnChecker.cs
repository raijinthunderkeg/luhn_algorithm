using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class LuhnChecker
    {
        public static bool Check(String number)
        {
            int i = number.Length;
            int sum = 0;
            while (i > 0)
            {
                int element = int.Parse(number.Substring(i-1,1));
                if ((i-1) % 2 == 0)
                {
                    element *= 2;
                    element = element>9?element/10+element%10:element;
                }
                sum += element;
                i--;
            }
            return sum%10==0;
        }
    }
}
