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
            
            Console.WriteLine("Adj meg egy sz�mot:");
            num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                throw new ArgumentException("Rossz sz�mot adt�l meg!");
            }
            else
            {
                Console.WriteLine("A megadott sz�m szorzatai: \n");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i * num);
                }
            }
        }
    }
}
