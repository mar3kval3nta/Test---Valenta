using System;
using System.Collections.Generic;
using System.Text;

namespace Test___Valenta
{
    public class Nakladak
    {
        public int nosnost;
        public int palivo;
        public int spotreba;
        public int vzdalenost;

        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int Palivo { get; set; }
        public int Spotreba { get; set; }
        public int Vzdalenost { get; set; }
        public int Naklad { get; set; }

        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 25000;
            Palivo = 1000;
            Spotreba = 25;
            Vzdalenost = 1500;
            Naklad = 0;
        }

        public void Nalozit()
        {
            Naklad += 2500;
            if (Naklad > 25000)
            {
                Naklad = 25000;
            }
        }

        public void Vylozit()
        {
            Naklad -= 2500;
            if(Naklad < 0)
            {
                Naklad = 0;
            }
        }

    }
}
