using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweWSB
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny = new List<Ocena>();

        public int Rok 
        { 
            get { return rok; }
            set { rok = value; }
        }

        public int Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }

        public int NrIndeksu
        {
            get { return nrIndeksu; }
            set { nrIndeksu = value; }
        }

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
            
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia + ", " + rok + ", " + grupa + ", " + nrIndeksu);
            WypiszOceny();
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(ocena);
        }

        public void WypiszOceny()
        {
            foreach (Ocena ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    ocena.WypiszInfo();
                }
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count; i++)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu) && o.Data.Equals(data) && o.Wartosc.Equals(wartosc))
                {
                    oceny.RemoveAt(i);
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            List<int> i = new List<int>();

            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    i.Add(oceny.IndexOf(ocena));
                }
            }

            foreach (int j in i)
            {
                oceny.RemoveAt(j - 1);
            }
        }
    }
}
