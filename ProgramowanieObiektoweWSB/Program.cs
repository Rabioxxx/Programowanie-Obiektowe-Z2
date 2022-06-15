using System;

namespace ProgramowanieObiektoweWSB
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Adam", "Miś", "20.03.1980"); 
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345); 
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "PC Czestochowa");
            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();
            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321); 
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");
            s.WypiszInfo();
            p.WypiszInfo();
            ((Pilkarz)o3).StrzelGola(); p.StrzelGola(); p.StrzelGola();
            o3.WypiszInfo(); p.WypiszInfo();

            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy Danych", "13.02.2011", 4.0);

            o2.WypiszInfo();

            s.DodajOcene("Bazy Danych", "01.05.2011", 5.0);
            s.DodajOcene("AWWW", "11.05.2011", 5.0);
            s.DodajOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.UsunOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.DodajOcene("AWWW", "02.04.2011", 4.5);
            s.UsunOceny("AWWW");

            s.WypiszInfo();

            s.DodajOcene("AWWW", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszInfo();

            Console.ReadKey();
        }

    }
}
