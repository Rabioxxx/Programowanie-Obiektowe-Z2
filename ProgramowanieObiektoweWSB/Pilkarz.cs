using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweWSB
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public string Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }

        public string Klub
        {
            get { return klub; }
            set { klub = value; }
        }

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public void StrzelGola()
        {
            liczbaGoli++;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia + ", " + pozycja + ", " + klub + ", " + liczbaGoli);
        }
    }
}
