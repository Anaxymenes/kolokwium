using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadania5i6
{
    class Student:IOsoba
    {
        public string imie;
        public string nazwisko;

        public void Opisz()
        {
            Console.WriteLine("Imie: " + this.imie + " Nazwisko:" + this.nazwisko);
        }
        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
