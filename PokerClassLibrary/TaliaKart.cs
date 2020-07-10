using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PokerClassLibrary
{
    public class TaliaKart : Karta
    {
        const int liczbaKart = 52;
        private List<Karta> talia;

        public TaliaKart()
        {
            talia = new List<Karta>(liczbaKart);
        }
        public List<Karta> getTalia { get { return talia; } }

        public void TworzenieTalii()
        {
            
            foreach (Rodzaj r in Enum.GetValues(typeof(Rodzaj)))
            {
                foreach (Wartość w in Enum.GetValues(typeof(Wartość)))
                {
                    talia.Add(new Karta { mojRodzaj = r, mojWartość = w });
                    
                }
            }
            Potasuj();
        }

        public void Potasuj()
        {
            Random random = new Random();
            Karta temp;

            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < liczbaKart; j++)
                {
                    int mieszamy = random.Next(liczbaKart);
                    temp = talia[j];
                    talia[j] = talia[mieszamy];
                    talia[mieszamy] = temp;
                }

            }
        }
        
        
     
    }
}
