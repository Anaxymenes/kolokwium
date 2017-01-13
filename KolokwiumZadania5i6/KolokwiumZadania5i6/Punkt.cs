using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadania5i6
{
    class Punkt:Figury
    {
        public int x;
        public int y;

        public override void LiczObwod()
        {
            Console.WriteLine("Obwód wynosi 0");
        }
        public override void PobierzDaneZKlawiatury()
        {
           // Console.Write("Podaj nazwę punktu: "); this.name = Console.ReadLine();
            Console.Write("Podaj X: "); this.x = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj Y: "); this.y = Int32.Parse(Console.ReadLine());
        }
        public override string Wyswietl()
        {
            return this.name + "(" + x + ";" + y+")";
        }
        public Punkt()
        {
            this.PobierzDaneZKlawiatury();
            Console.Clear();
            Console.WriteLine(this.ToString());
        }
    }
}
