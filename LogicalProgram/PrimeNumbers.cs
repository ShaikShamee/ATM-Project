using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
   public  class PrimeNumbers
    {
        public int a=0;
        public bool PrimeNumberMethod(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("number is less than zero");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
