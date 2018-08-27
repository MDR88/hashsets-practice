using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();

            Showroom.Add("CX-5");
            Showroom.Add("Stelvio");
            Showroom.Add("Elantra");
            Showroom.Add("SC-2");
            Showroom.Add("CX-5");

            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }

            HashSet<string> UsedLot = new HashSet<string>();

            UsedLot.Add("Civic");
            UsedLot.Add("Mustang");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Mustang");

            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }

            HashSet<string> Junkyard = new HashSet<string>() {
                ("CX-5"),
                ("Carolla"),
                ("Camry"),
                ("F-150"),
                ("Mustang"),
                ("Civic"),
            };

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);

            foreach (string left in clone)
            {
                Console.WriteLine($"clone{left}");
            }

            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Carolla");

            foreach (string car in Showroom)
            {
                Console.WriteLine($"final {car}");
            }

        }
    }
}
