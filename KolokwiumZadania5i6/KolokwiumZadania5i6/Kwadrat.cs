using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadania5i6
{
    class Kwadrat:Figury
    {
        Punkt A;
        Punkt B;
        Punkt C;
        Punkt D;

        public override void LiczObwod()
        {
       
            int wynik=0;
            Console.WriteLine("Obwód wynosi:" + wynik );
        }
        public override void PobierzDaneZKlawiatury()
        {
           // Console.Write("Podaj nazwę kwadratu: "); this.name = Console.ReadLine();
            A.PobierzDaneZKlawiatury();
            B.PobierzDaneZKlawiatury();
            C.PobierzDaneZKlawiatury();
            D.PobierzDaneZKlawiatury();
        }
        public override string Wyswietl()
        {
            return this.name + " Współrzędne pkt to A"+A.Wyswietl()+", B"+B.Wyswietl()+" C"+C.Wyswietl()+" D"+D.Wyswietl();
        }
        public Kwadrat()
        {
            A = new Punkt();
            B = new Punkt();
            C = new Punkt();
            D = new Punkt();
            
        }
    }
}
