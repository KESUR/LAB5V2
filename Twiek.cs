using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5V2
{
    class Twiek
    {
        private int lata, dni, godziny;
        public int Dni
        {
            get { return dni; }
            set
            {
                if ((value > 0) && (value < 365))
                {
                    dni = value;
                    Console.WriteLine($"Ilosc lat to 0, a ilosc dni to: {value}");
                }
                else if (value > 365)
                {
                    int przelicznikLat = value / 365;

                    lata += przelicznikLat;

                    int przelicznikDni = value % 365;

                    dni = przelicznikDni;

                }
            }
        }

        public int Godziny
        {
            get { return godziny; }
            set
            {
                if ((value > 0) && (value <= 24))
                {

                    godziny = value;

                }
                else if (value > 24)
                {
                    lata++;
                }
                else
                {
                    Console.WriteLine($"Godziny nie moga byc ujemne!");
                }
            }
        }

        public int Lata
        {
            get { return lata; }
            set
            {
                lata = value;
            }
        }

        public Twiek() { }

        public Twiek(int l, int d)
        {
            Lata = l;
            Dni = d;
        }
        public Twiek(int l, int d, int g)
        {
            Lata = l;
            Dni = d;
            Godziny = g;
        }
    }
}
