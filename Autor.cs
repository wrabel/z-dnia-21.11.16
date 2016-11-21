using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor(){ }

        public Autor(string imie, string nazwisko, string narodowosc) 
            :base(imie,nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Narodowosc: " + narodowosc);
        }
    }
}
