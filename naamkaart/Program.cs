using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naamkaart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Naam: ");
            string naam;
            naam = Console.ReadLine();
            Console.Write("Voornaam: ");
            string voornaam;
            voornaam = Console.ReadLine();
            Console.Write("straat: ");
            string straat;
            straat = Console.ReadLine();
            Console.Write("nummer: ");
            string nummer;
            nummer = Console.ReadLine();
            Console.Write("woonplaats: ");
            string woonplaats;
            woonplaats = Console.ReadLine();
            Console.Write("postcode: ");
            string postcode;
            postcode = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Naam: " + naam + " " + voornaam);
            Console.WriteLine("Adres: " + straat + " " + nummer + ", " + postcode + " " + woonplaats);
            
            Console.ReadLine();
        }
    }
}
