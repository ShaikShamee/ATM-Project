using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
   public class Factorial
    {

        public int factorial = 1;
        public int FactorialNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number is less than zero");
            }
            else if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
               
                for (int i = 1; i <= number; i++)
                {
                    
                    factorial = factorial * i;
                }
            }
            return factorial;
        }
        
    }
}
