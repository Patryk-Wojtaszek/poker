using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PokerClassLibrary
{
    public enum WszystkieOpcje
    {
        Poker, Kareta, Full, Kolor, Strit, Trójka, DwiePary, Para, WysokaKarta
    }
    public struct MocRęki
    {
        public int coMasz { get; set; }
        public int jakMocne { get; set; }
        public int najKarta { get; set; }
    }
    public class WartośćRęki : Karta
    {
        private MocRęki mocRęki;
        private List<Karta> karty;
        private int piki;
        private int trefle;
        private int kara;
        private int kiery;
        public WartośćRęki(List<Karta> karcioszki)
        {
            mocRęki = new MocRęki();
            karty = new List<Karta>(7);
            piki = 0;
            trefle = 0;
            kara = 0;
            kiery = 0;
        }



    }



}
