using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadania5i6
{
    class Kolo:Figury
    {
        Punkt punkt;
        public int r;

        public override void LiczObwod()
        {
            Console.WriteLine("Obwód wynosi:" + 2 * 3.14 * r);
        }
        public override void PobierzDaneZKlawiatury()
        {
            //Console.Write("Podaj nazwę koła: "); this.name = Console.ReadLine();
            Console.Write("Podaj promień okręgu r: "); r = Int32.Parse(Console.ReadLine());
        }
        public override string Wyswietl()
        {
            return " Pkt środka to (" + this.punkt.x + ";" + this.punkt.y+") i promień wynosi r="+this.r;
        }

        public Kolo()
        {
            punkt = new Punkt();
            this.PobierzDaneZKlawiatury();
            Console.Clear();
            Console.WriteLine(this.ToString());
            Console.ReadKey();

        }
    }
}
