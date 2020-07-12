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
        public int najKarta { get; set; }
    }
    public class WartośćRęki : Karta
    {
        private MocRęki mocRęki;
        private List<Karta> karta;
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

       public MocRęki mocRąk
        {
            get { return mocRąk; }
            set { mocRąk = value; }
        }
        public List<Karta> karty
        {
            get { return karty; }
            set
            {
                karty[0] = value[0];
                karty[1] = value[1];
                karty[2] = value[2];
                karty[3] = value[3];
                karty[4] = value[4];
                karty[5] = value[5];
                karty[6] = value[6];
            }
        }
        private void SumaKolorów()
        {
            foreach (Karta k in karty)
            {
                if (k.mojRodzaj == Karta.Rodzaj.Karo) kara++;
                if (k.mojRodzaj == Karta.Rodzaj.Kier) kiery++;
                if (k.mojRodzaj == Karta.Rodzaj.Pik) piki++;
                if (k.mojRodzaj == Karta.Rodzaj.Trefl) trefle++;
            }
        }
        private bool Kareta()
        {
            if (karty[0].mojWartość==karty[1].mojWartość && karty[0].mojWartość==karty[2].mojWartość && karty[0].mojWartość==karty[3].mojWartość)
            {
                mocRęki.coMasz = (int)karty[0].mojWartość * 4;
                mocRęki.najKarta = (int)karty[4].mojWartość;
                return true;
            }
            else if (karty[1].mojWartość == karty[2].mojWartość && karty[1].mojWartość == karty[3].mojWartość && karty[1].mojWartość == karty[4].mojWartość)
            {
                mocRęki.coMasz = (int)karty[1].mojWartość * 4;
                mocRęki.najKarta = (int)karty[0].mojWartość;
                return true;
            }
            else if (karty[2].mojWartość == karty[3].mojWartość && karty[2].mojWartość == karty[4].mojWartość && karty[2].mojWartość == karty[5].mojWartość)
            {
                mocRęki.coMasz = (int)karty[2].mojWartość * 4;
                mocRęki.najKarta = (int)karty[0].mojWartość;
                return true;
            }
            else if (karty[3].mojWartość == karty[4].mojWartość && karty[3].mojWartość == karty[5].mojWartość && karty[3].mojWartość == karty[6].mojWartość)
            {
                mocRęki.coMasz = (int)karty[3].mojWartość * 4;
                mocRęki.najKarta = (int)karty[0].mojWartość;
                return true;
            }
            return false;
        }
        private bool Full()
        {
            if ((karty[0].mojWartość == karty[1].mojWartość && karty[0].mojWartość == karty[2].mojWartość && karty[3].mojWartość == karty[4].mojWartość) ||
                (karty[0].mojWartość == karty[1].mojWartość && karty[2].mojWartość == karty[3].mojWartość && karty[2].mojWartość == karty[4].mojWartość))
            {
                mocRęki.coMasz = (int)karty[0].mojWartość + (int)karty[1].mojWartość + (int)karty[2].mojWartość + (int)karty[3].mojWartość +
                    (int)karty[4].mojWartość;
                return true;
            }
            return false;
        }
    }



}
