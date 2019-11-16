using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiczbyPierwsze.Main;

namespace LiczbyPierwsze.Konsola1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj gorny zakres liczb: ");
            
            int limit = Convert.ToInt32(Console.ReadLine());
            PrimaryNumbers pn = new PrimaryNumbers();
            var liczby = pn.GetAllToLimit(limit);
            foreach (var liczba in liczby) {
                Console.Write(liczba+" ");
            }
            Console.Write("\nPodaj dolny zakres: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.
                WriteLine("Ilosc liczb pierwszych w przedziale {0} {1} to {2} ",
                                           d,limit,pn.CountPrimaryNumbers(d,limit));
            Console.ReadKey();
        }
    }
}
