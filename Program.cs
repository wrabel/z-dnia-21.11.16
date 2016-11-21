using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor1 = new Autor("Wieslaw", "Plus", "Polska");
            autor1.WypiszInfo();
            Console.WriteLine();

            Ksiazka ksiazka1 = new Ksiazka("symfonia c++", 2, "cde", 3, 3, autor1);
            ksiazka1.WypiszInfo();
            Console.WriteLine();
            Czasopismo czasopismo1 = new Czasopismo("jestem numerem 3", 4, "eee", 2000, 3);
            czasopismo1.WypiszInfo();
            Console.WriteLine();

            Katalog katalog1 = new Katalog("aaa");
            katalog1.DodajPozycje(ksiazka1);
            katalog1.DodajPozycje(czasopismo1);


            katalog1.WyszkujPoTytule("jestem numerem 3");


            Console.ReadKey();
        }
    }
}
