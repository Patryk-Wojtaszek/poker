using System;
using System.Collections.Generic;
using PokerClassLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zagrajmy w Texas Holdem Poker! ");
            Console.WriteLine("1- zacznij grać, 2- co to jest Texas Holdem?, 0 - wyjdź z programu ");
            string a = Console.ReadLine();
            switch(a)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Niepoprawna Komenda, wpisz 0, 1, lub 2 ");
                    break;
            }
            /* Karta karta = new Karta();
             karta.mojRodzaj = Karta.Rodzaj.Karo;
             karta.mojWartość = Karta.Wartość.As;
             Console.WriteLine(karta);
             */
        }
    }
}
