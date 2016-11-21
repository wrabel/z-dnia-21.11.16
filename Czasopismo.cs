using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("rokWydania: " + rokWydania);
            Console.WriteLine("Numer: " + numer);
        }
 
    }
}
