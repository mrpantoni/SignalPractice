using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlagHomerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] months = new int[12, 30];
            int maxMonth = 0;
            int maxDay = 0;
            int minMonth = 0;
            int minDay = 0;
            int counter = 0;
            bool coldDaysinLine = false;

            for (int i = 0; i < 12; ++i)
            {
                if (i < 3)
                {
                    for (int j = 0; j < 30; ++j)
                    {
                        months[i, j] = random.Next(-20, 0); //tél
                    }
                }
                else if (i > 3 && i < 10)
                {
                    for (int j = 0; j < 30; ++j)
                    {
                        months[i, j] = random.Next(20, 40); //nyár
                    }
                }
                else
                {
                    for (int j = 0; j < 30; ++j)
                    {
                        months[i, j] = random.Next(0, 15); //tavasz & ősz
                    }
                }
            }

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    if (months[i, j] > months[maxMonth, maxDay])
                    {
                        maxMonth = i;
                        maxDay = j;
                    }
                    else if (months[i, j] < months[minMonth, minDay])
                    {
                        minMonth = i;
                        minDay = j;
                    }
                }
            }

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    if (months[i,j] < 0)
                    {
                        counter++;
                        if (counter == 5)
                        {
                            coldDaysinLine = true;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            Console.WriteLine($"A legmelegebb nap: {maxMonth + 1}.hónap {maxDay + 1}.napja {months[maxMonth, maxDay]} C°");

            Console.WriteLine($"A leghidegebb nap: {minMonth + 1}.hónap {minDay + 1}.napja {months[minMonth, minDay]} C°");

            if (coldDaysinLine)
            {
                Console.WriteLine($"Volt 5 napig mínusz!");
            }
            else
            {
                Console.WriteLine($"Nem volt-e 5 napig mínusz!");
            }

        }
    }
}
