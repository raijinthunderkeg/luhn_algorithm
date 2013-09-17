using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //4  5  6  1     2  6  1  2     1  2  3  4     5  4  6  4
            String firstNumber = "4561261212345464";
            Console.WriteLine("Check "+firstNumber + " : "+(LuhnChecker.Check(firstNumber)?"valid":"invalid") );
            //4  5  6  1     2  6  1  2     1  2  3  4     5  4  6  7
            firstNumber = "4561261212345467";
            Console.WriteLine("Check " + firstNumber + " : " + (LuhnChecker.Check(firstNumber) ? "valid" : "invalid"));
        }
    }
}
