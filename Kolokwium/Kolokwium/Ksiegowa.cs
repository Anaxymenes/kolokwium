using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Ksiegowa:Pracownik
    {

        public override void Pracuj()
        {
            Console.WriteLine("Ksiegowa pracuje!");
        }
        public Ksiegowa(string imie, string nazwisko, double zarobki)
            : base(imie, nazwisko, zarobki)
        {

        }
    }
}
