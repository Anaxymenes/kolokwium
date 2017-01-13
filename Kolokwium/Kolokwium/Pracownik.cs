using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Pracownik
    {
        protected string imie;
        protected string nazwisko;
        protected double zarobki;
        public string Imie { get { return this.imie; } set { this.imie = value; } }
        public string Nazwisko { get { return this.nazwisko; } set { this.nazwisko = value; } }
        public double Zarobki { get { return this.zarobki; } set { this.zarobki = value; } }
        public virtual void Pracuj()
        {
            Console.WriteLine("Pracownik pracuje");
        }
        public Pracownik(string imie, string nazwisko, double zarobki)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.zarobki = zarobki;
        }
    }
}
