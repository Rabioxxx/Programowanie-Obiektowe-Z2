using System;

namespace ProgramowanieObiektoweWSB
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Adam", "Miś", "20.03.1980"); 
            Osoba o2 = new Student("Michał", "Kot", "13.04.199e", 2, 1, 12345); 
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
            Console.ReadKey();
        }

    }
}
