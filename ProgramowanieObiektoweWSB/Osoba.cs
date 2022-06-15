using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweWSB
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public string Imie { get { return imie; } }
        public string Nazwisko { get { return nazwisko; } }
        public string DataUrodzenia { get { return dataUrodzenia; } }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        virtual public void WypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia);
        }
    }
}
