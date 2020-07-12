using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using PokerClassLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zagrajmy w Texas Holdem Poker! ");
            start();
            
            void start()
            {
                Console.WriteLine("1- zacznij grać, 2- co to jest Texas Holdem?, 0 - wyjdź z programu ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        
                        Rozdaj rozdaj = new Rozdaj();
                        rozdaj.Zaczynamy();
                        
                        break;
                    case "2":
                        Console.WriteLine("Texas Holdem to odmiana pokera gdzie spośród 2 prywantych kart na ręce, oraz 5 dostępnych dla wszystkich " +
                            "kart na stole, gracz wybiera kombinację 5 najlepszych kart.");
                        start();
                        break;
                    default:
                        Console.WriteLine("Niepoprawna Komenda, wpisz 0, 1, lub 2 ");
                        start();
                        break;
                }
            }


            /* Niestety projekt nie jest dokończony, troszkę przerosła mnie hierarchia kart przez to że wybrałem Texas Holdem a nie zwykłą wersję Pokera.
             */
        }
    }
}
