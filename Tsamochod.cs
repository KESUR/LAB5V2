using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5V2
{
    class Tsamochod : Twiek
    {
        int lata, dni, godziny;

        public string Marka;
        protected string model;
        private int moc;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine($"Nie ma podanej wartosci!");
                }
                else
                {
                    model = value;
                }
            }
        }

        public int Moc
        {
            get
            {
                return moc;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Nie ma podanej wartosci!");
                }
                else
                {
                    moc = value;
                }
            }
        }

        public Tsamochod() { }

        public Tsamochod(string marka, string model, int moc)
        {
            Marka = marka;
            this.model = model;
            this.moc = moc;
        }

        public Tsamochod(Twiek wiek)
        {
            lata = wiek.Lata;
            dni = wiek.Dni;
            godziny = wiek.Godziny;
        }
    }
}
