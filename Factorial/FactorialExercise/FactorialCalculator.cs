using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExercise.Exercises
{
    //Készítsünk rekurzív faktoriális és hatványt számító függvényeket!
    public static class FactorialCalculator
    {
        public static int FactorialRecursion(int factNum)
        {
            if (factNum < 0)
            {
                throw new ArgumentException("Only Positive number accepted!");
            }
            else if (factNum == 0)
            {
                return 1;
            }
            else
            {
                return factNum * FactorialRecursion(factNum - 1);
            }
        }

        public static double ExponentiationRecursion(double baseNum, int exponentNum)
        {
            if (baseNum < 0 || exponentNum < 0)
            {
                throw new ArgumentException("Only Positive number accepted!");
            }
            else if (exponentNum == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * ExponentiationRecursion(baseNum, exponentNum - 1);
            }
        }
    }
}