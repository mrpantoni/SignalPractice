using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Szorzotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Adj meg egy számot:");
            num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                throw new ArgumentException("Rossz számot adtál meg!");
            }
            else
            {
                Console.WriteLine("A megadott szám szorzatai: \n");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i * num);
                }
            }
        }
    }
}
