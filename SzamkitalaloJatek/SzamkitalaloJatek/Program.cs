using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamkitalaloJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numToFind = random.Next(100);
            int userGuess = 0;

            while (userGuess != numToFind)
            {
                Console.Write("Adj meg egy számot ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numToFind)
                {
                    Console.WriteLine($"{userGuess} A szám ennél kisebb!", userGuess);
                }
                else if (userGuess < numToFind)
                {
                    Console.WriteLine($"{userGuess} A szám ennél nagyobb!", userGuess);
                }
                else
                {
                    Console.WriteLine($"{userGuess} Tökéletes, eltaláltad!");
                }
            }
        }
    }
}
