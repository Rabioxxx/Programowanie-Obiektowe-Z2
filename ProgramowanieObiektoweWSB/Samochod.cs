using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweWSB
{
    public class Samochod
    {
        static int liczbaSamochodow = 0;

        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        private double srednieSpalanie;

        public Samochod()
        {
            this.marka = "nieznany";
            this.model = "nieznany";
            this.iloscDrzwi = 0;
            this.pojemnoscSilnika = 0.0;
            this.srednieSpalanie = 0.0;
            liczbaSamochodow++;
        }

        public Samochod(string marka, string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            liczbaSamochodow++;
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private double ObliczSpalanie(double distance)
        {
            return (srednieSpalanie * distance) / 100.0;
        }

        public double ObliczKosztPrzejazdu(double distance, double fuelPrice)
        {
            return ObliczSpalanie(distance) * fuelPrice;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Liczba drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemnosc silnika: " + pojemnoscSilnika);
            Console.WriteLine("Srednie spalanie: " + srednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Liczba samochodów: " + liczbaSamochodow);
        }
    }
}
