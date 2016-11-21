using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private Autor ksiazkaAutor;

        public Ksiazka() { }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, Autor ksiazkaAutor) 
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.ksiazkaAutor = ksiazkaAutor;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("rokWydania: " + rokWydania);
            Console.WriteLine("Liczba Stron: " + liczbaStron);
            Console.WriteLine("Autor: ");
            ksiazkaAutor.WypiszInfo();

        }
    }
}
