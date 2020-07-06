using System;
using System.Collections.Generic;
using PokerClassLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zagrajmy w Pokera! ");
            Karta karta = new Karta();
            karta.mojRodzaj = Karta.Rodzaj.Karo;
            karta.mojWartość = Karta.Wartość.As;
            Console.WriteLine(karta);
        }
    }
}
