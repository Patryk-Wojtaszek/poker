using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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
        public void Zaczynamy()
        {
            TworzenieTalii();
            Ręka();
            Rysuj();
        }
        public void Ręka()
        {
            for (int i = 0; i < 2; i++)
            {
                gracz.Add(getTalia[i]);

            }
            for (int i = 2; i < 4; i++)
            {
                komputer.Add(getTalia[i]);
            }
            for (int i = 4; i < 9; i++)
            {
                flop.Add(getTalia[i]);
            }
   
        }
        public void Rysuj()
        {
            Console.Write("Twoje karty:                   ");
         for (int i = 0; i < gracz.Count; i++)
            {
                Console.Write(gracz[i]+"                   ");
            }
            Console.WriteLine("\n \n \n \n");
            Console.Write("Flop:         ");
            for (int i = 0; i < flop.Count; i++)
            {
                Console.Write(flop[i] + "           ");
            }
            Console.WriteLine("\n \n \n \n");
            Console.Write("Karty   CPU:                   ");
            for (int i = 0; i < komputer.Count; i++)
            {
                Console.Write(komputer[i] + "                   ");
            }

        }
        }
  



    }

