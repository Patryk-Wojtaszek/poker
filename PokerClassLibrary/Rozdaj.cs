using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PokerClassLibrary
{
    public class Rozdaj : TaliaKart
    {
        private List<Karta> gracz;
        private List<Karta> komputer;
        private List<Karta> flop;

        public Rozdaj()
        {
            gracz = new List<Karta>(2);
            komputer = new List<Karta>(2);
            flop = new List<Karta>(5);
        }
    }
}
