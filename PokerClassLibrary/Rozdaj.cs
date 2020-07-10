using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PokerClassLibrary
{
    public class Rozdaj : TaliaKart
    {
        private List<Karta> gracz;
        private List<Karta> komputer;
        private List<Karta> flop;
        private List<Karta> rekaGracza;
        private List<Karta> rekaCPU;
        private List<Karta> sortujGracz;
        private List<Karta> sortujCPU;


        public Rozdaj()
        {
            gracz = new List<Karta>(2);
            komputer = new List<Karta>(2);
            flop = new List<Karta>(5);
            rekaGracza = new List<Karta>(7);
            rekaCPU = new List<Karta>(7);
            sortujGracz = new List<Karta>(7);
            sortujCPU = new List<Karta>(7);

        }
        public void Zaczynamy()
        {
            TworzenieTalii();
            Ręka();
            Rysuj();
            Porównaj();
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
            Console.WriteLine("\n \n");

        }
        public void Porównaj()
        {

            foreach (Karta k in gracz)
            {
                rekaGracza.Add(k);
            }
            foreach (Karta k in komputer)
            {
                rekaCPU.Add(k);
            }
            foreach  (Karta k  in flop)
            {
                rekaGracza.Add(k);
                rekaCPU.Add(k);
            }
             var sortujemy = from bla in rekaGracza
                          orderby bla.mojWartość descending
                          select bla;
            foreach (var v in sortujemy)
            {
                sortujGracz.Add(v);
            }

            sortujemy = from bla in rekaCPU
                        orderby bla.mojWartość descending
                        select bla;
            foreach (var v in sortujemy)
            {
                sortujCPU.Add(v);
            }
            
            /*foreach (Karta k in sortujGracz)
            {
                Console.WriteLine(k);
            }
            foreach (Karta k in sortujCPU)
            {
                Console.WriteLine(k);
            }
            */


        }
        }
  



    }

