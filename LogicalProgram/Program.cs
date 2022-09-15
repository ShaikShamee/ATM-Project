using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            //string answer = "Y";
            //while (answer == "Y")
            //{
            //    Console.WriteLine("Enter the 1 to get the factorial");
            //    Console.WriteLine("Enter the 2 to get the factorial");
            //    int print = int.Parse(Console.ReadLine());
            //    Factorial factorial = new Factorial();
            //    PrimeNumbers primeNumbers = new PrimeNumbers();
            //    switch (print)
            //    {
            //        case 1:
            //            Action action = new Action(factorial.FactorialNumber);
            //            action.Invoke();
            //            break;
            //        case 2:
            //            Action action1 = new Action(primeNumbers.PrimeNumberMethod);
            //            action1.Invoke();
            //            break;
            //        default:
            //            Console.WriteLine("please select above metioned options ");
            //            break;
            //    }
            //    Console.WriteLine("Do you want o contine Y/N");
            //    answer = Console.ReadLine();
            //}
            //Factorial f = new Factorial();
            //Console.WriteLine(f.FactorialNumber(6));
            PrimeNumbers p = new PrimeNumbers();
            Console.WriteLine(p.PrimeNumberMethod(5));
            Console.ReadLine();
        }
    }
}
