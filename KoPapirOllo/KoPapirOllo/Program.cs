using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            char playerChoice = ' ';
            char aiChoise = ' ';

            int playerScore = 0;
            int aiScore = 0;
            bool endGame = true;
            
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Kő, Papír, vagy Olló? (Kezdőbetűt írj)");

                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case 'k':
                            playerChoice = 'k';
                            break;
                        case 'p':
                            playerChoice = 'p';
                            break;
                        case 'o':
                            playerChoice = 'o';
                            break;
                        default: throw new ArgumentException("A JÁTÉK VÉGET ÉRT!");
                    }

                    switch (random.Next(0, 3))
                    {
                        case 0:
                            aiChoise = 'k';
                            break;
                        case 1:
                            aiChoise = 'p';
                            break;
                        case 2:
                            aiChoise = 'o';
                            break;
                    }

                    if ((playerChoice == 'k' && aiChoise == 'p') ||
                        (playerChoice == 'p' && aiChoise == 'o') ||
                        (playerChoice == 'o' && aiChoise == 'k'))
                    {
                        Console.WriteLine($"\nVesztettél! Az állás:\nSzámítógép: {++aiScore}\nJátékos: {playerScore}");
                    }
                    else if (playerChoice == aiChoise)
                    {
                        Console.WriteLine($"\nDöntetlen! Az állás:\nSzámítógép: {aiScore}\nJátékos: {playerScore}");
                    }
                    else
                    {
                        Console.WriteLine($"\nNyertél! Az állás:\nSzámítógép: {aiScore}\nJátékos: {++playerScore}");
                    }
                }
                Console.WriteLine($"\nVÉGEREDMÉNY:\nSzámítógép: {aiScore}\nJátékos: {playerScore}");

                Console.WriteLine("Új játék? (i/n)");

                if (Console.ReadKey(true).KeyChar == 'n') { endGame = false; }
            } while (endGame);
        }
    }
}
