using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Sprzedawca:Pracownik
    {
        public override void Pracuj()
        {
            Console.WriteLine("Sprzedawca pracuje");
        }
        public Sprzedawca(string imie, string nazwisko, double zarobki)
            : base(imie, nazwisko, zarobki)
        {

        }
    }
}
