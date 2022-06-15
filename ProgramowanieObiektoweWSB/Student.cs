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
        }
    }
}
