using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweWSB
{
    public class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;
        
        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres, int pojemnosc)
        {
            this.adres = adres;
            this.pojemnosc = pojemnosc;
            samochody = new Samochod[pojemnosc];
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (liczbaSamochodow < pojemnosc)
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
                return;
            }
            Console.WriteLine("Garaż jest pełen.");
        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                return null;
            }
            else
            {
                Samochod wyprowadzonySamochod = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;
                return wyprowadzonySamochod;
            }
        }

        public void WypiszInfo()
        {
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
