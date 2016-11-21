using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Katalog : Pozycja, IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        public List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void DodajPozycje(Pozycja obiekt)
        {
            listaPozycji.Add(obiekt);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("rokWydania: " + rokWydania);
        }

        

        public void WyszkujPoTytule(string tytul)
        {
            foreach (var element in listaPozycji)
            {
                if (element.GetTytul() == tytul)
                    element.WypiszInfo();
            }
        }



        public void WyszukajPoId(int id)
        {
            foreach (var element in listaPozycji)
            {
                if (element.GetId() == id)
                    element.WypiszInfo();
            }

        }

        public void WypiszWszystko()
        {
            foreach (var element in listaPozycji)
            {
                element.WypiszInfo();
            }
        }
    }
}
