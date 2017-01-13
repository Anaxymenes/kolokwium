using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Skrzypek:Pracownik
    {
        public override void Pracuj()
        {
            Console.WriteLine("Skrzypek pracuje");
        }
        public Skrzypek(string imie, string nazwisko, double zarobki):base(imie,nazwisko,zarobki)
        {

        }
    }
}
