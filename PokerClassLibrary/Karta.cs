using System;
using System.Collections.Generic;

namespace PokerClassLibrary
{
    public class Karta
    {
        public enum Rodzaj
        {
            Kier,
            Karo,
            Pik,
            Trefl,
        }

        public enum Wartość
        {
            Dwójka, Trójka, Czwórka, Piątka, Szóstka, Siódemka, Ósemka, Dziewiątka, Dziesiątka, Walet, Dama, Król, As 
        }

        public Rodzaj mojRodzaj { get; set; }
        public Wartość mojWartość { get; set; }


    }
    
}

